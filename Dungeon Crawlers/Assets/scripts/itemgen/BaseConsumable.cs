using UnityEngine;
using System.Collections;

public class BaseConsumable : BaseItemStat {

	public enum ConsumableTypes
    {
        POTION,
        FOOD
    }

    public enum PotionTypes
    {
        HEALTH,
        CHARISMA,
        LUCK,
        AGILITY,
        STRENGTH,
        SPEED,
        COMBO,
    }

    public enum FoodTypes
    {
        BREAD,
        MEAT,
        FRUIT,
        ROOT,
        TINCTURE,
        BOTTLE
    }

    private ConsumableTypes consumableType;
    private PotionTypes potionType;
    private FoodTypes foodType;
    private int spellEffectID;

    public ConsumableTypes ConsumableType
    {
        get
        {
            return consumableType;
        }

        set
        {
            consumableType = value;
        }
    }

    public int SpellEffectID
    {
        get
        {
            return spellEffectID;
        }

        set
        {
            spellEffectID = value;
        }
    }

    public FoodTypes FoodType
    {
        get
        {
            return foodType;
        }

        set
        {
            foodType = value;
        }
    }

    public PotionTypes PotionType
    {
        get
        {
            return potionType;
        }

        set
        {
            potionType = value;
        }
    }
}
