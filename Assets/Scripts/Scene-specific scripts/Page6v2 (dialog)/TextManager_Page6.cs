using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Page6 : MonoBehaviour
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    private int lineupIndex = 1;
    [SerializeField]
    public Button nextButton;

    public static TextManager_Page6 instance;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        Lineup();
        Exceptions();

        paragraphs[0].GetComponent<TMPro.TextMeshProUGUI>().enabled = true;
        nextButton.onClick.AddListener(TaskOnClick);

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
