using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static int lastDoor = -1;
    public Transform door1;
    public Transform door2;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        if(lastDoor == 1)
        {
            player.position = door1.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
