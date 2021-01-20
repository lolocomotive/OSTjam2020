using UnityEngine;

internal class BackpackItem : MonoBehaviour, Item
{
    public Sprite image { get; set; }

    public BackpackItem(Sprite backpackSprite)
    {
        this.image = backpackSprite;
    }

}