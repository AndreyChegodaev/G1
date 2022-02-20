using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Page55A: MonoBehaviour 
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

    void Exceptions()
    {

    }

    void Lineup()
    {
        // this looks spooky but it is basically: put an object beneath at (1/2 of the width of object above + 1/2 width of the object beneath)

        paragraphs[1].transform.position = paragraphs[0].transform.position + Vector3.down * (paragraphs[0].GetComponent<Collider2D>().bounds.extents.y + paragraphs[1].GetComponent<Collider2D>().bounds.extents.y + .1f);
        paragraphs[2].transform.position = paragraphs[1].transform.position + Vector3.down * (paragraphs[1].GetComponent<Collider2D>().bounds.extents.y + paragraphs[2].GetComponent<Collider2D>().bounds.extents.y + .1f);
        paragraphs[3].transform.position = paragraphs[2].transform.position + Vector3.down * (paragraphs[2].GetComponent<Collider2D>().bounds.extents.y + paragraphs[3].GetComponent<Collider2D>().bounds.extents.y + .1f);
    }
}
