using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class SaveManager : MonoBehaviour
{
    public static SaveManager instance;

    public bool hasLoaded;
    private Button saveButton;
    private Button loadButton;
    //public Button deleteButton;
    
    public SaveData activeSave;

    

    private void Awake()
    {
        instance = this;
        
        Load();

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        saveButton.onClick.AddListener(Save);
        loadButton.onClick.AddListener(Load);
        //deleteButton.onClick.AddListener(Delete);

    }

    void Update()
    {

    }

    public void Save()
    {
        string dataPath = Application.persistentDataPath;

        var serializer = new XmlSerializer(typeof(SaveData));
        var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".save", FileMode.Create);
        serializer.Serialize(stream, activeSave);
        stream.Close();

        //Debug.Log("Saved");
    }

    public void Load()
    {
        string dataPath = Application.persistentDataPath;

        if (System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".save"))
        {
            var serializer = new XmlSerializer(typeof(SaveData));
            var stream = new FileStream(dataPath + "/" + activeSave.saveName + ".save", FileMode.Open);
            activeSave = serializer.Deserialize(stream) as SaveData;
            stream.Close();

            hasLoaded = true;
            //Debug.Log("Loaded");
        }
    }

   /* public void Delete()
    {
        string dataPath = Application.persistentDataPath;

        if (System.IO.File.Exists(dataPath + "/" + activeSave.saveName + ".save"))
        {
            File.Delete(dataPath + "/" + activeSave.saveName + ".save");

            Debug.Log("Deleted");
        }*/
}

// This is a new proprietary class, created for save data
[System.Serializable]
public class SaveData
{
    public string saveName;
    public string currentLevel;
    public bool firstPlaytrough = true;
    public bool onTree = false;
    public bool hasFork = false;
    public bool hasFinger = false;
    public int dejaVu = 0;
    public bool visitedWitch = false;
    public bool killedByWitch = false;
    public bool crossedRavine = false;
    public bool setHomeFromTower = false;
    public int waitAtTheDoor = 0;
    public bool keptTheRing = false;
    public bool heardVoice = false;
    public bool fakeEnding = false;
    public bool trueEnding = false;

    public enum ActivePicture
    {
        nothing,
        bad_tower,
        bad_ash,
        ok_back,
        ok_tower_man,
        goodish,
    }
    public ActivePicture activePicture;
}
