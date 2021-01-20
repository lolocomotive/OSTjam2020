using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinClickable : MonoBehaviour, Clickable
{
    public Inventory inv;
    public Sprite coinSprite;
    public Transform player;
    public float distanceToClick;

    public void click()
    {
        if (Vector2.Distance(player.position, this.transform.position) < distanceToClick)
        {
            inv.addItem(new Coin(coinSprite));
            Debug.Log("Click potato");
            Destroy(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        inv = InventoryHandler.inv;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
