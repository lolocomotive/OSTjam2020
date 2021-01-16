using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory
{
    public Image[] slots = new Image[4];
    public Item[] items = new Item[4];
    public Inventory(Image slot1, Image slot2, Image slot3, Image slot4)
    {
        slots[0] = slot1;
        slots[1] = slot2;
        slots[2] = slot3;
        slots[3] = slot4;
    }

    public void setSlots(Image slot1, Image slot2, Image slot3, Image slot4)
    {
        slots[0] = slot1;
        slots[1] = slot2;
        slots[2] = slot3;
        slots[3] = slot4;
    }

    public void addItem(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == default(Item))
            {
                items[i] = item;
                break;
            }
            else if (i == 4)
            {
                return;
            }
        }
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == default(Item))
            {
                break;
            }
            slots[i].sprite = items[i].image;
        }
    }
    public void refresh()
    {
        for(int i = 0; i < items.Length; i++)
        {
            if (items[i] == default(Item))
            {
                break;
            }
            slots[i].sprite = items[i].image;
        }
    }
}
