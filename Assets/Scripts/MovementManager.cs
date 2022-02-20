using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementManager : MonoBehaviour
{
    public GameObject[] movements;
    private int spawnIndex = 0;
    //[SerializeField] public Button nextButton;

    private void Start()
    {
        movements[0].SetActive(true);
        //nextButton.onClick.AddListener(TaskOnClick);
    }
    public void TaskOnClick()
    {
        spawnIndex++;
                    
        movements[spawnIndex].SetActive(true);
        movements[spawnIndex - 1].SetActive(false);

    }
}
