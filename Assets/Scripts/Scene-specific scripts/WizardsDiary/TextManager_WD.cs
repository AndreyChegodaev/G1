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
        var achievement = new Steamworks.Data.Achievement("ACHIEVEMENT_IJWSS").Trigger();
    }
    public void TaskOnClick()
    {

        if (spawnIndex <= paragraphs.Count - 1)
        {
            int i = spawnIndex++;
            paragraphs[i].SetActive(true);
            pictures[i].SetActive(true);
        }

    }
}
