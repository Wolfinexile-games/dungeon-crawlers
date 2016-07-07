using UnityEngine;
using System.Collections;

public class BaseItemStat : BaseItem {

    private int charisma;
    private int luck;
    private int agility;
    private int strength;
    private int speed;

    public int Charisma
    {
        get
        {
            return charisma;
        }

        set
        {
            charisma = value;
        }
    }

    public int Luck
    {
        get
        {
            return luck;
        }

        set
        {
            luck = value;
        }
    }

    public int Agility
    {
        get
        {
            return agility;
        }

        set
        {
            agility = value;
        }
    }

    public int Speed
    {
        get
        {
            return speed;
        }

        set
        {
            speed = value;
        }
    }

    public int Strength
    {
        get
        {
            return strength;
        }

        set
        {
            strength = value;
        }
    }
}
