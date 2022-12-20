using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TooltipSystem : MonoBehaviour
{
    private static TooltipSystem instance;

    public Tooltip tooltip;

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        if (instance.tooltip.gameObject != null) // added recently - maybe a mistske
            Hide();
    }

    public static void Show(string content, string header = "")
    {
            instance.tooltip.gameObject.SetActive(true);
            instance.tooltip.SetText(content, header);
            instance.tooltip.gameObject.SetActive(true);

    }

    public static void Hide()
    {
        if (instance.tooltip != null)
        instance.tooltip.gameObject.SetActive(false);
    }
}
