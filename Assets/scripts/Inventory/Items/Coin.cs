using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Item
{
    public Sprite image { get; set; }

    public Coin(Sprite s)
    {
        image = s;
    }
}
