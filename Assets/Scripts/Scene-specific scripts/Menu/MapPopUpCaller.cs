using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapPopUpCaller : MonoBehaviour
{
    public GameObject mapPopUp;
    string buttonName;
    string rewriteThis;

    // Start is called before the first frame update
    void Start()
    {
        buttonName = gameObject.name;
        rewriteThis = gameObject.name;
    }


    public void TaskOnClick()
    {
        mapPopUp.SetActive(true);
        mapPopUp.transform.position = Input.mousePosition;
        MapPopUp.instance.buttonName = buttonName;
        MapPopUp.instance.rewriteMethodName = rewriteThis;
    }

}
