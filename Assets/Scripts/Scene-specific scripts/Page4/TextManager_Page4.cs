using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Page4: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    private int lineupIndex = 1;
    [SerializeField]
    public Button nextButton;

    public static TextManager_Page4 instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        nextButton.onClick.AddListener(TaskOnClick);

        Exceptions();
        Lineup();

    }
    public void TaskOnClick()
    { 
        int i = spawnIndex++;            

        paragraphs[i].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
    }

    void Exceptions()
        // Here's the thing - mind the element's updated position in the collection after each .Remove line is executed
    {
        if (SaveManager.instance.activeSave.hasFork == false && SaveManager.instance.activeSave.hasFinger == false)
        {

            paragraphs.Remove(paragraphs[2]);
            paragraphs.Remove(paragraphs[2]);
            paragraphs.Remove(paragraphs[2]);
        }

        else if (SaveManager.instance.activeSave.hasFork == true && SaveManager.instance.activeSave.hasFinger == false)
        {

            paragraphs.Remove(paragraphs[1]);
            paragraphs.Remove(paragraphs[2]);
            paragraphs.Remove(paragraphs[2]);
        }

        else if (SaveManager.instance.activeSave.hasFork == false && SaveManager.instance.activeSave.hasFinger == true)
        {
            paragraphs.Remove(paragraphs[1]);
            paragraphs.Remove(paragraphs[1]);
            paragraphs.Remove(paragraphs[2]);
        }

        else
        {
            paragraphs.Remove(paragraphs[1]);
            paragraphs.Remove(paragraphs[1]);
            paragraphs.Remove(paragraphs[1]);
        }
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
