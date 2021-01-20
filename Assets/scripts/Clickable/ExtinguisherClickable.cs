using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtinguisherClickable : MonoBehaviour, Clickable
{
    public Inventory inv;
    public Sprite extinguisherSprite;
    public Transform player;
    public float distanceToClick;
    public int oid;

    public void click()
    {
        if (Vector2.Distance(player.position, this.transform.position) < distanceToClick)
        {
            inv.addItem(new ExtinguisherItem(extinguisherSprite));
            Lab.destroyedObjs.Add(oid);
            StaircaseMovement.hasExt = true;
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
