using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Destroy : MonoBehaviour, Clickable
{
    public void click()
    {
        Hothouse.destroy.Add(this.gameObject);
        Destroy(this.gameObject);

    }
}
