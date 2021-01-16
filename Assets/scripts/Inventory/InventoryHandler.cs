using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryHandler : MonoBehaviour
{
    public static Inventory inv;
    public Image slot1;
    public Image slot2;
    public Image slot3;
    public Image slot4;
    private void Awake()
    {
        if (inv == default(Inventory))
        {
            Debug.Log("Creating new Inventory object...");
            inv = new Inventory(slot1, slot2, slot3, slot4);
        }
        else
        {
            inv.setSlots(slot1, slot2, slot3, slot4);
            inv.refresh();
        }
    }
}
