using UnityEngine;
using System.Collections;
using System;

public class CreateNewConsumable : MonoBehaviour
{

    private BaseConsumable newConsumable;
    // Use this for initialization
    void Start()
    {
        CreateConsumable();
        Debug.Log(newConsumable.ItemID.ToString());
        Debug.Log(newConsumable.ItemName.ToString());
        Debug.Log(newConsumable.ItemDescription.ToString());
    }

    private void CreateConsumable()
    {
        int randomNumber = UnityEngine.Random.Range(1, 3);
        switch (randomNumber)
        {
            case 1:
                newConsumable = new BasePotion();
                newConsumable.ConsumableType = BaseConsumable.ConsumableTypes.POTION;
                ChoosePotionType();
                newConsumable.ItemName = (newConsumable.PotionType.ToString() + " Potion");
                newConsumable.ItemDescription = "An oddly colored liquid in a flask.";
                break;
            case 2:
                newConsumable = new BaseFood();
                newConsumable.ConsumableType = BaseConsumable.ConsumableTypes.FOOD;
                ChooseFoodType();
                newConsumable.ItemName = newConsumable.FoodType.ToString();
                break;
            default:
                break;
        }

        newConsumable.ItemID = Guid.NewGuid();
    }

    public void ChoosePotionType()
    {
        int randomNumber = UnityEngine.Random.Range(1, 8);
        switch (randomNumber)
        {
            case 1:
                newConsumable.PotionType = BaseConsumable.PotionTypes.HEALTH;
                break;
            case 2:
                newConsumable.PotionType = BaseConsumable.PotionTypes.CHARISMA;
                newConsumable.Charisma = UnityEngine.Random.Range(1, 3);
                break;
            case 3:
                newConsumable.PotionType = BaseConsumable.PotionTypes.LUCK;
                newConsumable.Luck = UnityEngine.Random.Range(1, 3);
                break;
            case 4:
                newConsumable.PotionType = BaseConsumable.PotionTypes.AGILITY;
                newConsumable.Agility = UnityEngine.Random.Range(1, 3);
                break;
            case 5:
                newConsumable.PotionType = BaseConsumable.PotionTypes.STRENGTH;
                newConsumable.Strength = UnityEngine.Random.Range(1, 3);
                break;
            case 6:
                newConsumable.PotionType = BaseConsumable.PotionTypes.SPEED;
                newConsumable.Speed = UnityEngine.Random.Range(1, 3);
                break;
            case 7:
                newConsumable.PotionType = BaseConsumable.PotionTypes.COMBO;
                newConsumable.Charisma = UnityEngine.Random.Range(0, 3);
                newConsumable.Luck = UnityEngine.Random.Range(0, 3);
                newConsumable.Agility = UnityEngine.Random.Range(0, 3);
                newConsumable.Strength = UnityEngine.Random.Range(0, 3);
                newConsumable.Speed = UnityEngine.Random.Range(0, 3);
                break;
            default:
                break;
        }
    }
    public void ChooseFoodType()
    {
        int randomNumber = UnityEngine.Random.Range(1, 7);
        switch (randomNumber)
        {
            case 1:
                newConsumable.FoodType = BaseConsumable.FoodTypes.BREAD;
                newConsumable.ItemDescription = "A piece of stale bread.";
                break;
            case 2:
                newConsumable.FoodType = BaseConsumable.FoodTypes.MEAT;
                newConsumable.ItemDescription = "An tin full of rancid smelling fleshy stuff.";
                break;
            case 3:
                newConsumable.FoodType = BaseConsumable.FoodTypes.FRUIT;
                newConsumable.ItemDescription = "A very strange looking fruit.";
                break;
            case 4:
                newConsumable.FoodType = BaseConsumable.FoodTypes.ROOT;
                newConsumable.ItemDescription = "A hard but malleable root.";
                break;
            case 5:
                newConsumable.FoodType = BaseConsumable.FoodTypes.TINCTURE;
                newConsumable.ItemDescription = "A tincture with an unknown red liquid.";
                break;
            case 6:
                newConsumable.FoodType = BaseConsumable.FoodTypes.BOTTLE;
                newConsumable.ItemDescription = "A Bottle full of a liquid with no distinguishable smell.";
                break;
            default:
                break;
        }
    }
}
