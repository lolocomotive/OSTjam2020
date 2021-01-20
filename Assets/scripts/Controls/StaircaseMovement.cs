using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaircaseMovement : MonoBehaviour
{
    public static bool hasExt = false;
    public static bool hasBP = false;
    public Transform start;
    public Transform end;
    public Transform player;
    public Rigidbody2D playerRb;
    public Transform target;
    public float minDistance;
    public float speed;
    public float startDistance;
    public GameObject msg;
    // Start is called before the first frame updat
    // Update is called once per frame
    void FixedUpdate()
    {
        if (target != default(Transform))
        {
            player.position = Vector3.MoveTowards(player.position, target.position, Time.fixedDeltaTime * speed);
            if (Vector2.Distance(player.position, target.position) < startDistance)
            {
                if (target == start)
                {
                    target = end;
                }
                else
                {
                    target = default(Transform);
                    playerRb.simulated = true;
                    Debug.Log("Target reached");
                }
            }
        }
    }
    public void checkForStairCase()
    {
        float d = Vector2.Distance(start.position, player.position);
        if (d < minDistance && hasBP && hasExt)
        {
            if (target == default(Transform))
            {
                Debug.Log("Going on staircase");
                target = start;
                playerRb.simulated = false;
                player.GetComponent<PlayerMovement2D>().updateDirection(-1);
            }
        }
    }

    private void Update()
    {
        if(hasBP && hasExt)
        {
            msg.SetActive(true);
        }
    }

}
