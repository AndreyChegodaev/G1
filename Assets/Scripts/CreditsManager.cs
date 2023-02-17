using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CreditsManager : MonoBehaviour, IPointerDownHandler
{
    public Image background;
    public GameObject textContainer;
    public Transform creditsFinalPosition;

    public float fadeInSecs = 1f;
    public int textRollSpeed = 10;

    public bool finalScene = false;
    private bool rollTextFlag = false;
   

    // Start is called before the first frame update
    void Start()
    {

        background.enabled = false;
        textContainer.SetActive(false);
        if (finalScene == true)
        {
            var achievement = new Steamworks.Data.Achievement("ACHIEVEMENT_HappilyEverAfter").Trigger();
        }

    }

    void Update()
    {
        if( rollTextFlag == true)
        {
            RollText();
        }

    }

    public void ShowCredits()
    {
        background.enabled = true;
        background.CrossFadeAlpha(0f, 0f, true);
        background.GetComponent<Image>().raycastTarget = true;
        background.CrossFadeAlpha(1f, fadeInSecs, false);
        StartCoroutine(ShowText());
    }

    IEnumerator ShowText()
    {
        yield return new WaitForSeconds(fadeInSecs + 1);
        textContainer.SetActive(true);
        rollTextFlag = true;
        RollText();

    }

    private void RollText()
    {
        textContainer.transform.position = Vector2.MoveTowards(textContainer.transform.position, creditsFinalPosition.position, textRollSpeed * Time.deltaTime);
        if (textContainer.transform.position == creditsFinalPosition.transform.position)
        {
            Invoke("CloseCredits", 5);
        }

    }

    private void CloseCredits()
    {
        if (finalScene == false)
        {
            background.CrossFadeAlpha(0f, 0f, true);
            rollTextFlag = false;
            textContainer.SetActive(false);
            textContainer.transform.position = new Vector3(gameObject.GetComponentInParent<Transform>().position.x, gameObject.GetComponentInParent<Transform>().position.y);
            background.enabled = false;
        }
        else
        {
            SaveManager.instance.Save();
            SceneManager.LoadScene("Postscriptum");
            SaveManager.instance.activeSave.currentLevel = "Postscriptum";
            GameManager.instance.PS_Unlocked();
        }
            
           


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        CloseCredits();
    }

}
