using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_WD: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    public List<GameObject> pictures = new List<GameObject>();
    private int spawnIndex = 1;
    [SerializeField]
    public Button nextButton;

    private void Start()
    {
        paragraphs[0].SetActive(true);
        pictures[0].SetActive(true);
        nextButton.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    { 
        int i = spawnIndex++; 
        paragraphs[i].SetActive(true);
        pictures[i].SetActive(true);
    }
}
