using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour, Clickable
{
    public Transform player;
    public float distanceToClick;
    public string scene;
    public int doorID;

    public void click()
    {
        if (Vector2.Distance(player.position, this.transform.position) < distanceToClick)
        {
            Debug.Log("Going to scene "+scene);
            DoorManager.lastDoor = doorID;
            SceneManager.LoadScene(scene);
        }
    }
}
