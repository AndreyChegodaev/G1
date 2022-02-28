using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Page3C: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    private int lineupIndex = 1;
    [SerializeField]
    public Button nextButton;

    public static TextManager_Page3C instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Exceptions();
        Lineup();

        nextButton.onClick.AddListener(TaskOnClick);

    }
    public void TaskOnClick()
    {
        int i = spawnIndex++;

        paragraphs[i].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
    }

    void Exceptions()
    {
        if (SaveManager.instance.activeSave.onTree == false)
        {
            paragraphs[1].transform.position = paragraphs[0].transform.position + Vector3.down * 0.25f;
            paragraphs[1].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
            paragraphs.Remove(paragraphs[0]);
        }
        else
            paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;

    }

    void Lineup()
    {
        foreach (GameObject paragraph in paragraphs)
        {
            paragraphs[lineupIndex].transform.position = paragraphs[lineupIndex - 1].transform.position + Vector3.down * (paragraphs[lineupIndex - 1].GetComponent<Collider2D>().bounds.extents.y + paragraphs[lineupIndex].GetComponent<Collider2D>().bounds.extents.y + .1f);

            if (lineupIndex < paragraphs.Count - 1)
            {
                lineupIndex++;
            }
        }
    }
}
