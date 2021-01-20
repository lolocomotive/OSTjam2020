using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherItem : Item
{
    public Sprite image { get; set; }

    public ExtinguisherItem(Sprite s)
    {
        image = s;
    }
}
