using UnityEngine;
using System.Collections;

public class BaseCharacterClass{

    private string characterClassName;
    private string characterClassDescription;
    //stats
    private int charisma;
    private int luck;
    private int agility;
    private int strength;
    private int speed;

    public string CharacterClassName
    {
        get
        {
            return characterClassName;
        }

        set
        {
            characterClassName = value;
        }
    }

    public string CharacterClassDescription
    {
        get
        {
            return characterClassDescription;
        }

        set
        {
            characterClassDescription = value;
        }
    }

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
}
