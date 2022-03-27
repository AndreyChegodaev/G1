using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CCManager : MonoBehaviour

{
    public static CCManager instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        
        gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        instance.gameObject.SetActive(true);
    }

    public void Hide()
    {
        instance.gameObject.SetActive(false);
    }
}
