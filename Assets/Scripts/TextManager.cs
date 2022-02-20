using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    [SerializeField]
    public Button nextButton;

    private void Start()
    {
        paragraphs[0].SetActive(true);
        nextButton.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    {
        int i = spawnIndex++;
        paragraphs[i].SetActive(true);

        if (paragraphs[paragraphs.Count - 2].activeSelf == true)
        {
            paragraphs[paragraphs.Count - 1].SetActive(true);
        }
    }
}
