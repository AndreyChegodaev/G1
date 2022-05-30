using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WelcomeManager : MonoBehaviour
{
    [SerializeField] Button x;

    void Start()
    {
        x.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        gameObject.SetActive(false);
    }

}
