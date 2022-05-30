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
        //saveButton.onClick.AddListener(Save);
        //loadButton.onClick.AddListener(Load);
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

    public bool settings_CCSwitch = false;
    public bool settings_MusicSwitch = true;
    public bool settings_VoiceSwitch = true;
    public bool settings_WelcomePopUp = true;


    public bool f1B_Unlocked = false;
    public bool f3O_1_Unlocked = false;
    public bool f3O_2_Unlocked = false;
    public bool f3O_3_Unlocked = false;
    public bool f4G_Unlocked = false;
    public bool f5T_Unlocked = false;
    public bool page1_Unlocked = true; //level 1
    public bool page2_Unlocked = false;
    public bool page35_Unlocked = false;
    public bool page3A_Unlocked = false;
    public bool page3B_Unlocked = false;
    public bool page3C_Unlocked = false;
    public bool page4_Unlocked = false;
    public bool page55A_Unlocked = false;
    public bool page55B_Unlocked = false;
    public bool page5_Unlocked = false;
    public bool page5v2_Unlocked = false;
    public bool page65A_Unlocked = false;
    public bool page6v1_Unlocked = false;
    public bool page6v2_Unlocked = false;
    public bool page7_Unlocked = false;
    public bool page8_Unlocked = false;
    public bool page9A_Unlocked = false;
    public bool page9B_Unlocked = false;
    public bool page9C_Unlocked = false;
    public bool page10_Unlocked = false;
    public bool page11A_Unlocked = false;
    public bool pS_Unlocked = false;
    public bool pF1B_Unlocked = false;
    public bool pF2B_Unlocked = false;
    public bool pF3O_1_Unlocked = false;
    public bool pF3O_2_Unlocked = false;
    public bool pF3O_3_Unlocked = false;
    public bool pF4G_Unlocked = false;
    public bool pF5T_Unlocked = false;
}
