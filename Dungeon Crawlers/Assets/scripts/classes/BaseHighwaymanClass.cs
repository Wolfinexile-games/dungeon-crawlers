using UnityEngine;
using System.Collections;

public class BaseHighwaymanClass : BaseCharacterClass {

    public BaseHighwaymanClass()
    {
        CharacterClassName = "Highwayman";
        CharacterClassDescription = "A Road Warrior searching for a righteous cause.";
        Charisma = 3;
        Luck = 3;
        Agility = 7;
        Strength = 5;
        Speed = 7;
    }
}
