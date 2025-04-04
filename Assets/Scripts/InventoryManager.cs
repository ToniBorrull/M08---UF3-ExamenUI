using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public RectTransform rect;
    public GameObject inventory;
    public Slider horizontal, vertical;
    Inputs inputs;
    private void Start()
    {
        inputs = new Inputs();
        inputs.Player.Enable();
    }
    private void Update()
    {
        if (inputs.Player.Inventory.WasPressedThisFrame())
        {
            if (inventory.activeSelf)
            {
                inventory.SetActive(false);
            }
            else
            {
                inventory.SetActive(true);
            }
        }
    }

    public void ChangeHorizontalRect()
    {
       rect.sizeDelta = new Vector2(horizontal.value, rect.sizeDelta.y);
    }
    public void ChangeVerticalRect()
    {
        rect.sizeDelta = new Vector2(rect.sizeDelta.x, vertical.value);
    }
}
