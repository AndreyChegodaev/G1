using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogTextManager_Page11A : MonoBehaviour
{
    public static DialogTextManager_Page11A instance;

    public List<GameObject> paragraphs = new List<GameObject>();

    [SerializeField]
    Image princess;

    [SerializeField]
    Image princessUp;

    [SerializeField]
    Image notPrincess;

    [SerializeField]
    Image notPrincessUp;

    [SerializeField]
    Button nextButton;
    [SerializeField]
    Button previousButton;

    enum WhoStartsDialog
    {
        startsWithNarrator,
        startsWithPrincess,
        startsWithNotPrincess,
    }

    [SerializeField]
    WhoStartsDialog whoStartsDialog;


    public int currentSpawnIndex = 0;


    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {

        princessUp.CrossFadeAlpha(0f, 0f, false);
        princess.CrossFadeAlpha(0f, 0f, false);
        notPrincessUp.CrossFadeAlpha(0f, 0f, false);
        notPrincess.CrossFadeAlpha(0f, 0f, false);

        paragraphs[0].SetActive(true);
        nextButton.onClick.AddListener(TaskOnClickForward);
        previousButton.onClick.AddListener(TaskOnClickBackward);

        if (whoStartsDialog == WhoStartsDialog.startsWithNarrator)
        {
            princessUp.CrossFadeAlpha(0f, 0f, false);
            princess.CrossFadeAlpha(1f, 0f, false);

            notPrincessUp.CrossFadeAlpha(0f, 0f, false);
            notPrincess.CrossFadeAlpha(1f, 0f, false);

        }

        if (whoStartsDialog == WhoStartsDialog.startsWithPrincess)
        {
            princessUp.CrossFadeAlpha(1f, 0f, false);
            princess.CrossFadeAlpha(0f, 0f, false);

            notPrincessUp.CrossFadeAlpha(0f, 0f, false);
            notPrincess.CrossFadeAlpha(1f, 0f, false);

        }

        if (whoStartsDialog == WhoStartsDialog.startsWithNotPrincess)
        {
            princessUp.CrossFadeAlpha(0f, 0f, false);
            princess.CrossFadeAlpha(1f, 0f, false);

            notPrincessUp.CrossFadeAlpha(1f, 0f, false);
            notPrincess.CrossFadeAlpha(0f, 0f, false);

        }

    }
    public void TaskOnClickForward()
    {
        currentSpawnIndex++;
        int a = currentSpawnIndex - 1;

        paragraphs[currentSpawnIndex].SetActive(true);
        paragraphs[a].SetActive(false);

        HighlightCharacter();
    }

    public void TaskOnClickBackward()
    {
        currentSpawnIndex--;
        int a = currentSpawnIndex + 1;

        paragraphs[currentSpawnIndex].SetActive(true);
        paragraphs[a].SetActive(false);

        HighlightCharacter();
    }

    public void HighlightCharacter()
    {
        if (paragraphs[currentSpawnIndex].tag == "PrincessDialogLine")
        {
            princessUp.CrossFadeAlpha(1f, 0f, false);
            princess.CrossFadeAlpha(0f, 0f, false);

            notPrincessUp.CrossFadeAlpha(0f, 0f, false);
            notPrincess.CrossFadeAlpha(1f, 0f, false);

        }
        else if (paragraphs[currentSpawnIndex].tag == "NotPrincessDialogLine")
        {
            princessUp.CrossFadeAlpha(0f, 0f, false);
            princess.CrossFadeAlpha(1f, 0f, false);

            notPrincessUp.CrossFadeAlpha(1f, 0f, false);
            notPrincess.CrossFadeAlpha(0f, 0f, false);
        }
        else
        {
            princessUp.CrossFadeAlpha(0f, 0f, false);
            princess.CrossFadeAlpha(1f, 0f, false);

            notPrincessUp.CrossFadeAlpha(0f, 0f, false);
            notPrincess.CrossFadeAlpha(1f, 0f, false);
        }

    }

}
