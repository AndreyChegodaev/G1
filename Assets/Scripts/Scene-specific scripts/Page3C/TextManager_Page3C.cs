using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager_Page3C: MonoBehaviour 
{
    public List<GameObject> paragraphs = new List<GameObject>();
    private int spawnIndex = 0;
    [SerializeField]
    public Button nextButton;

    private void Start()
    {
        Lineup();
        Exceptions();

        paragraphs[0].SetActive(true);
        nextButton.onClick.AddListener(TaskOnClick);        

    }
    public void TaskOnClick()
    { 
        int i = spawnIndex++;            

        paragraphs[i].SetActive(true);

        if (paragraphs[paragraphs.Count - 2].activeSelf == true)
        {           
            paragraphs[paragraphs.Count - 1].SetActive(true);
        }
    }

    void Exceptions()
    {
        if (SaveManager.instance.activeSave.onTree == false)
        {
            paragraphs[1].transform.position = paragraphs[0].transform.position + Vector3.down * .2f;
            paragraphs[2].transform.position = paragraphs[1].transform.position + Vector3.down * 1.2f;
            paragraphs[3].transform.position = paragraphs[2].transform.position + Vector3.down * 1.2f;
            paragraphs.Remove(paragraphs[0]);                   
        }
    }

    void Lineup()
    {
        paragraphs[1].transform.position = paragraphs[0].transform.position + Vector3.down * 1.2f;
        paragraphs[2].transform.position = paragraphs[1].transform.position + Vector3.down * 1.2f;
        paragraphs[3].transform.position = paragraphs[2].transform.position + Vector3.down * 1.2f;
    }
}
