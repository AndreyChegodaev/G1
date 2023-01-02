using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Reflection;

public class MapPopUp : MonoBehaviour
{
    public static MapPopUp instance;
    public string buttonName;
    public string rewriteMethodName;

    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);

    }


    public void LoadScene()
    {

        //MethodInfo method = MapManager.instanceMapManager.GetType().GetMethod("rewriteMethodName", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
        //method.Invoke(MapManager.instanceMapManager, null);
        GameObject.Find("MapManager").SendMessage(rewriteMethodName);


        SaveManager.instance.Save();
        SceneManager.LoadScene(buttonName);

        SaveManager.instance.activeSave.currentLevel = buttonName;
    }
}
