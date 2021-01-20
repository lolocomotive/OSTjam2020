using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Livingroom : MonoBehaviour
{
    public Transform obj1;
    public Transform obj2;
    public static List<int> destroyedObjs = new List<int>();
    // Start is called before the first frame update
    void Start()
    {
        foreach (int i in destroyedObjs)
        {
            switch (i)
            {
                case 1:
                    Destroy(obj1.gameObject);
                    break;
                case 2:
                    Destroy(obj2.gameObject);
                    break;
            }
        }
    }
}
