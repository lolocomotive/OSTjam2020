using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Destroy : MonoBehaviour, Clickable
{
    public int oid;
    public void click()
    {
        Hothouse.destroyedObjs.Add(oid);
        Destroy(gameObject);
    }
}
