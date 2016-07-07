using UnityEngine;
using System.Collections;
using System;

public class BaseItem {

    private string itemName;
    private string itemDescription;
    private Guid itemID;
    public enum ItemTypes
    {
        WEAPON, EQUIPMENT, CONSUMABLE, RELIGIOUS, CONTAINER
    }

    private ItemTypes itemType;

    public string ItemName
    {
        get
        {
            return itemName;
        }

        set
        {
            itemName = value;
        }
    }

    public string ItemDescription
    {
        get
        {
            return itemDescription;
        }

        set
        {
            itemDescription = value;
        }
    }

    public ItemTypes ItemType
    {
        get
        {
            return itemType;
        }

        set
        {
            itemType = value;
        }
    }

    public Guid ItemID
    {
        get
        {
            return itemID;
        }

        set
        {
            itemID = value;
        }
    }
}
