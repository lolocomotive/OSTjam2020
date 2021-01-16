using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test :MonoBehaviour, Clickable
{
    // Start is called before the first frame update
    public void click()
    {
        this.transform.Translate(new Vector3(10,10,10));
    }
}
