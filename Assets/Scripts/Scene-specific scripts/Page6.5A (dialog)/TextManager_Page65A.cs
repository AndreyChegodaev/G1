using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Page65A: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    [SerializeField]
    public Button nextButton;

    public static TextManager_Page65A instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        nextButton.onClick.AddListener(TaskOnClick); 
    }
    public void TaskOnClick()
    {
        int i = spawnIndex++;

        paragraphs[i].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
    }
}
