using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item
{
   public enum ItemType
    {
        Wearable,
        Misc,
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Wearable:         return ItemAssets.Instance.wearableSprite;
            case ItemType.Misc:         return ItemAssets.Instance.miscSprite;
        }
    }
}
