using UnityEngine;
using System.Collections;
using System;

public class CreateNewEquipment : MonoBehaviour {

    void Start()
    {
        CreateEquipment();
        
        Debug.Log(newEquipment.ItemName);
        Debug.Log(newEquipment.ItemDescription);
        Debug.Log(newEquipment.ItemID.ToString());
        Debug.Log(newEquipment.Charisma.ToString());
        Debug.Log(newEquipment.Luck.ToString());
        Debug.Log(newEquipment.Agility.ToString());
        Debug.Log(newEquipment.Strength.ToString());
        Debug.Log(newEquipment.Speed.ToString());
        Debug.Log(newEquipment.EquipmentType.ToString());
        
    }

    private BaseEquipment newEquipment;

    public void CreateEquipment()
    {
        newEquipment = new BaseEquipment();

        newEquipment.ItemName = "Equipment " + UnityEngine.Random.Range(1, 101);
        newEquipment.ItemDescription = "Equipment Desc " + UnityEngine.Random.Range(1, 101);
        newEquipment.ItemID = Guid.NewGuid();
        ChooseEquipmentType();
    }

    public void setAttributes()
    {
        newEquipment.Charisma = UnityEngine.Random.Range(1, 3);
        newEquipment.Luck = UnityEngine.Random.Range(1, 3);
        newEquipment.Agility = UnityEngine.Random.Range(1, 3);
        newEquipment.Strength = UnityEngine.Random.Range(1, 3);
        newEquipment.Speed = UnityEngine.Random.Range(1, 3);
    }

    private void ChooseEquipmentType()
    {
        int randomNumber = UnityEngine.Random.Range(1, 9);
        switch (randomNumber)
        {
            case 1:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HEAD;
                break;
            case 2:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.NECK;
                setAttributes();
                break;
            case 3:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BACK;
                break;
            case 4:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.CHEST;
                break;
            case 5:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.HANDS;
                break;
            case 6:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FINGERS;
                setAttributes();
                break;
            case 7:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.BELT;
                break;
            case 8:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.LEGS;
                break;
            case 9:
                newEquipment.EquipmentType = BaseEquipment.EquipmentTypes.FEET;
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }

    }
}
