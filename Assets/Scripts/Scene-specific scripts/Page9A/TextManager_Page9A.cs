using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Page9A : MonoBehaviour
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    private int lineupIndex = 1;
    [SerializeField]
    public Button nextButton;

    public static TextManager_Page9A instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ExceptionPrimary();
        Lineup();

        if (SaveManager.instance.activeSave.waitAtTheDoor <=3)
        {
            paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        }


        nextButton.onClick.AddListener(TaskOnClick);
    }

    public void TaskOnClick()
    {
        if (spawnIndex <= paragraphs.Count - 1)
        {
            int i = spawnIndex++;

            paragraphs[i].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        }



        /*        if (SaveManager.instance.activeSave.waitAtTheDoor == 1)
                {
                    if (paragraphs[1].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
                    {
                        foreach (GameObject paragraph in paragraphs)
                        {
                            paragraph.GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
                        }
                    }
                }
                else if(SaveManager.instance.activeSave.waitAtTheDoor > 1 && SaveManager.instance.activeSave.waitAtTheDoor < 4)
                {
                    if (paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
                    {
                        foreach (GameObject paragraph in paragraphs)
                        {
                            paragraph.GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
                        }
                    }
                }*/

    }

    void ExceptionPrimary()
    {
        //ExceptionsChoices();
        ExceptionsParagraphs();
        paragraphs.RemoveAll(item => item == null);
    }

    /*    void ExceptionsChoices()
        {
            if (SaveManager.instance.activeSave.hasFinger == false)
            {
                paragraphs[6] = null;
                paragraphs[7] = null;
            }
        }*/

    void ExceptionsParagraphs()
    {
        if (SaveManager.instance.activeSave.waitAtTheDoor <= 1)
        {
            paragraphs[1] = null;
            paragraphs[2] = null;
            //paragraphs[8] = null;
        }

        else if (SaveManager.instance.activeSave.waitAtTheDoor == 2)
        {
            paragraphs[0] = null;
            paragraphs[2] = null;
            //paragraphs[8] = null;
        }

        else if (SaveManager.instance.activeSave.waitAtTheDoor == 3)
        {
            paragraphs[0] = null;
            paragraphs[1] = null;
            //paragraphs[8] = null;
        }

        else
        {
            paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = false;
            paragraphs[1].GetComponent<TMPro.TextMeshProUGUI>().enabled = false;
            paragraphs[2].GetComponent<TMPro.TextMeshProUGUI>().enabled = false;
            paragraphs[3].GetComponent<TMPro.TextMeshProUGUI>().enabled = false;
            //paragraphs[4] = null;
            //paragraphs[5] = null;
            //paragraphs[6] = null;
            //paragraphs[7] = null;
            //paragraphs[8].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
            nextButton.interactable = false;
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
