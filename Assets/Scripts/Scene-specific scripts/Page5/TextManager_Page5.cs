using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Page5: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    private int lineupIndex = 1;
    [SerializeField]
    public Button nextButton;

    private void Start()
    {
        Exceptions();
        Lineup();
        
        paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        nextButton.onClick.AddListener(TaskOnClick);

    }
    public void TaskOnClick()
    {
        int i = spawnIndex++;

        paragraphs[i].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
    }

    void Exceptions()
    {
        if (SaveManager.instance.activeSave.dejaVu >= 1)
        {
            paragraphs[0] = null;
        }
       
        /*if (SaveManager.instance.activeSave.firstPlaytrough == true)
        {
            paragraphs[6] = null;
        } else
        {
            paragraphs[5] = null;
        }*/
        paragraphs.RemoveAll(item => item == null);

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
