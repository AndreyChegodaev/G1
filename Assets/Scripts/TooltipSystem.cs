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
        if (instance.tooltip.gameObject != null)
        instance.tooltip.gameObject.SetActive(false);
    }
}
