using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Page8: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    private int lineupIndex = 1;
    [SerializeField]
    public Button nextButton;

    public static TextManager_Page8 instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        ExceptionPrimary();
        Lineup();
        paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;

       /* if (SaveManager.instance.activeSave.heardVoice == true)
        {
            if (paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
            {
                paragraphs[1].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
                paragraphs[2].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
                paragraphs[3].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
                paragraphs[4].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
            }
        }*/

        nextButton.onClick.AddListener(TaskOnClick);



    }
    public void TaskOnClick()
    { 
        int i = spawnIndex++;            

        paragraphs[i].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;

        /*if (SaveManager.instance.activeSave.hasFinger == true)
        {
            if (paragraphs[2].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
            {
                paragraphs[3].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
                paragraphs[4].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
                paragraphs[5].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
                paragraphs[6].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
            }
        } else
        {
            if (paragraphs[2].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
            {
                paragraphs[3].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
                paragraphs[4].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
            }
        }*/
        
    }

    void ExceptionPrimary()
    {
        if (SaveManager.instance.activeSave.heardVoice == true)
        {
            ExceptionsSecondary1();
        }
        else
        {
            ExceptionsSecondary2();
        }
    }

    void ExceptionsSecondary1()
    {
        paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        paragraphs[1] = null;
        paragraphs[2] = null;
        paragraphs[3] = null;

/*        if (SaveManager.instance.activeSave.hasFinger == false)
        {
            paragraphs[6] = null;
            paragraphs[7] = null;
        }*/

        paragraphs.RemoveAll(item => item == null);


    }

    void ExceptionsSecondary2()
    {
            paragraphs[0] = null;

/*        if (SaveManager.instance.activeSave.hasFinger == false)
        {
            paragraphs[6] = null;
            paragraphs[7] = null;
        }*/

        paragraphs.RemoveAll(item => item == null);
    }

    void Lineup()
    {
        foreach (GameObject paragraph in paragraphs) 
        {
            paragraphs[lineupIndex].transform.position = paragraphs[lineupIndex-1].transform.position + Vector3.down * (paragraphs[lineupIndex-1].GetComponent<Collider2D>().bounds.extents.y + paragraphs[lineupIndex].GetComponent<Collider2D>().bounds.extents.y + .1f);
           
            if (lineupIndex < paragraphs.Count-1)
            {
                lineupIndex++;
            }
        }
    }
}
