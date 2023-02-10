using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailerControl : MonoBehaviour
{

    public GameObject princess;
    
    private ScriptScene_Page1 scriptScene;

    void Start()
    {
        scriptScene = princess.GetComponent<ScriptScene_Page1>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            scriptScene.TaskOnClick();
        }
    }

    
}
