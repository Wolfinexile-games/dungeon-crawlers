using UnityEngine;
using System.Collections;
using System;

public class CreateNewReligiousItem : MonoBehaviour {

    private BaseReligious newReligiousItem;

	void Start()
    {

    }

    private void CreateReligiousItem()
    {
        newReligiousItem = new BaseReligious();
        ChooseItemReligion();
        ChooseReligiousItem();
        newReligiousItem.ItemName = (newReligiousItem.ReligiousType.ToString() + newReligiousItem.ReligiousItemType.ToString());
        newReligiousItem.ItemDescription = "A religious artifact.";
        newReligiousItem.ItemID = Guid.NewGuid();
        newReligiousItem.SpellEffectID = 1;
    }

    private void ChooseItemReligion()
    {
        int randomNumber = UnityEngine.Random.Range(1, 5);
        switch (randomNumber)
        {
            case 1:
                newReligiousItem.ReligiousType = BaseReligious.ReligiousTypes.HOLY;
                break;
            case 2:
                newReligiousItem.ReligiousType = BaseReligious.ReligiousTypes.SATANIC;
                break;
            case 3:
                newReligiousItem.ReligiousType = BaseReligious.ReligiousTypes.OCCULT;
                break;
            case 4:
                newReligiousItem.ReligiousType = BaseReligious.ReligiousTypes.VOODOO;
                break;
            default:
                break;
        }
    }
    private void ChooseReligiousItem()
    {
        int randomNumber = UnityEngine.Random.Range(1, 5);
        switch (randomNumber)
        {
            case 1:
                newReligiousItem.ReligiousItemType = BaseReligious.ReligiousItemTypes.IDOL;
                break;
            case 2:
                newReligiousItem.ReligiousItemType = BaseReligious.ReligiousItemTypes.VESSEL;
                break;
            case 3:
                newReligiousItem.ReligiousItemType = BaseReligious.ReligiousItemTypes.CHALICE;
                break;
            case 4:
                newReligiousItem.ReligiousItemType = BaseReligious.ReligiousItemTypes.AMULET;
                break;
            case 5:
                newReligiousItem.ReligiousItemType = BaseReligious.ReligiousItemTypes.DOLL;
                break;
            default:
                break;
        }
    }
}
