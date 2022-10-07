using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_PF3O: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    [SerializeField]
    public Button nextButton;

    private void Start()
    {
        nextButton.onClick.AddListener(TaskOnClick);

        Exceptions();
        Lineup();
        paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
       
        if (paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
        {
            paragraphs[paragraphs.Count - 1].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        }

    }
    public void TaskOnClick()
    {
        if (spawnIndex <= paragraphs.Count - 1)
        {
        int i = spawnIndex++;            

        paragraphs[i].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        }

    }

    void Exceptions()
    {
        if (SaveManager.instance.activeSave.setHomeFromTower == true)
        {
            paragraphs.Remove(paragraphs[1]);
        }
        else
        {
            paragraphs.Remove(paragraphs[0]);
        }



    }

    void Lineup()
    {
        // this looks spooky but it is basically: put an object beneath at (1/2 of the width of object above + 1/2 width of the object beneath)

        paragraphs[1].transform.position = paragraphs[0].transform.position + Vector3.down * (paragraphs[0].GetComponent<Collider2D>().bounds.extents.y + paragraphs[1].GetComponent<Collider2D>().bounds.extents.y + .2f);     
    }
}
