using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_PF1B: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    private int lineupIndex = 1;
    [SerializeField]
    public Button nextButton;

    public static TextManager_PF1B instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        nextButton.onClick.AddListener(TaskOnClick);

        ExceptionsPrimary();
        Lineup();

    }
    public void TaskOnClick()
    { 
        int i = spawnIndex++;            

        paragraphs[i].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;

        if (paragraphs[paragraphs.Count - 2].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
        {
            paragraphs[paragraphs.Count - 1].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        }

    }

    void ExceptionsPrimary()
    {
        if (SaveManager.instance.activeSave.hasFinger == true)
        {
            ExceptionHasFinger();
        }
        else ExceptionHasNoFinger();
    }

    void ExceptionHasFinger()
    {
        paragraphs.Remove(paragraphs[5]);
        paragraphs.Remove(paragraphs[5]);
        paragraphs.Remove(paragraphs[5]);

        if (SaveManager.instance.activeSave.hasFork == true)
        {
            paragraphs.Remove(paragraphs[3]);
        }
        else paragraphs.Remove(paragraphs[4]);
    }

    void ExceptionHasNoFinger()
    {
        paragraphs.Remove(paragraphs[2]);
        paragraphs.Remove(paragraphs[2]);
        paragraphs.Remove(paragraphs[2]);

        if (SaveManager.instance.activeSave.hasFork == true)
        {
            paragraphs.Remove(paragraphs[3]);
        }
        else paragraphs.Remove(paragraphs[4]);
    }

    void Lineup()
    {
        foreach (GameObject paragraph in paragraphs)
        {
            paragraphs[lineupIndex].transform.position = paragraphs[lineupIndex - 1].transform.position + Vector3.down * (paragraphs[lineupIndex - 1].GetComponent<Collider2D>().bounds.extents.y + paragraphs[lineupIndex].GetComponent<Collider2D>().bounds.extents.y + .2f);

            if (lineupIndex < paragraphs.Count - 1)
            {
                lineupIndex++;
            }
        }
    }
}
