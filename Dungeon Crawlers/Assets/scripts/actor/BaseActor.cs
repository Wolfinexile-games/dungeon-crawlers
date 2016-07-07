using UnityEngine;
using System.Collections;

public class BaseActor {

    private string actorName;
    private int actorLevel;
    private BaseCharacterClass actorClass;
    private int actorXP;
    private int charisma;
    private int luck;
    private int agility;
    private int strength;
    private int speed;

    public string ActorName
    {
        get
        {
            return actorName;
        }

        set
        {
            actorName = value;
        }
    }

    public int ActorLevel
    {
        get
        {
            return actorLevel;
        }

        set
        {
            actorLevel = value;
        }
    }

    public BaseCharacterClass ActorClass
    {
        get
        {
            return actorClass;
        }

        set
        {
            actorClass = value;
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

    public int ActorXP
    {
        get
        {
            return actorXP;
        }

        set
        {
            actorXP = value;
        }
    }
}
