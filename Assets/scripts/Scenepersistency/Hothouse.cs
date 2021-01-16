using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hothouse : MonoBehaviour
{
    public static List<GameObject> destroy = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject obj in destroy)
        {
            Destroy(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
