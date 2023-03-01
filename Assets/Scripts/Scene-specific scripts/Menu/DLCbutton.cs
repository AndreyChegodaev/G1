using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DLCbutton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    private Animator animator;
    private Camera cam;
    private Transform camPosition;
    private Vector3 startCamPosition;
    public GameObject DLCPopup;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        camPosition = cam.transform;
        startCamPosition = new Vector3(camPosition.position.x, camPosition.position.y, camPosition.position.z);
        DLCPopup.SetActive(false);
    }

    private void Update()
    {
        if (camPosition.position != startCamPosition)
        {
            gameObject.SetActive(false);
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        animator.SetTrigger("Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator.SetTrigger("Exit");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.SetActive(false);
        DLCPopup.SetActive(true);

    }
}

