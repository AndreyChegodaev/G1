using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenuButtonManager : MonoBehaviour
{
    public GameObject backToMenuButton;

    void Start()
    {
        backToMenuButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf == true) backToMenuButton.gameObject.SetActive(true);
        else backToMenuButton.gameObject.SetActive(false);
    }
}
