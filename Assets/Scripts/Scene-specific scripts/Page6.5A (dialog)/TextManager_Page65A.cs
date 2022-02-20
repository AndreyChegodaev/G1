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

    private void Start()
    {
        Lineup();
        Exceptions();

        paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        nextButton.onClick.AddListener(TaskOnClick); 
        
        // VVV usually the lines below are in the TaskOnClick but on Page6.5A there is only one paragraph before the choice button

        if (paragraphs[paragraphs.Count - 2].GetComponent<TMPro.TextMeshProUGUI>().enabled == true)
        {
            paragraphs[paragraphs.Count - 1].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        }

    }
    public void TaskOnClick()
    {
        int i = spawnIndex++;

        paragraphs[i].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
    }

    void Exceptions()
    {

    }

    void Lineup()
    {
        paragraphs[1].transform.position = paragraphs[0].transform.position + Vector3.down * (paragraphs[0].GetComponent<Collider2D>().bounds.extents.y + paragraphs[1].GetComponent<Collider2D>().bounds.extents.y + .1f);
    }
}
