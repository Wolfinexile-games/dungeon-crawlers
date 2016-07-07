using UnityEngine;
using System.Collections;
using System;

public class CreateNewWeapon : MonoBehaviour {

    void Start()
    {
        CreateWeapon();
        /*
        Debug.Log(newWeapon.ItemName);
        Debug.Log(newWeapon.ItemDescription);
        Debug.Log(newWeapon.ItemID.ToString());
        Debug.Log(newWeapon.HealthDamage.ToString());
        Debug.Log(newWeapon.BleedChance.ToString());
        Debug.Log(newWeapon.BlightChance.ToString());
        Debug.Log(newWeapon.BleedDamage.ToString());
        Debug.Log(newWeapon.BlightDamage.ToString());
        Debug.Log(newWeapon.Charisma.ToString());
        Debug.Log(newWeapon.Luck.ToString());
        Debug.Log(newWeapon.Agility.ToString());
        Debug.Log(newWeapon.Strength.ToString());
        Debug.Log(newWeapon.Speed.ToString());
        Debug.Log(newWeapon.WeaponType.ToString());
        */
    }

    private BaseWeapon newWeapon;

    public void CreateWeapon()
    {
        newWeapon = new BaseWeapon();

        newWeapon.ItemName = "Weapon " + UnityEngine.Random.Range(1, 101);
        newWeapon.ItemDescription = "Weapon Desc" + UnityEngine.Random.Range(1, 101);
        newWeapon.ItemID = Guid.NewGuid();
        newWeapon.HealthDamage = UnityEngine.Random.Range(10, 21);
        newWeapon.BleedChance = UnityEngine.Random.Range(1, 101);
        newWeapon.BlightChance = UnityEngine.Random.Range(1, 101);
        newWeapon.BleedDamage = UnityEngine.Random.Range(1, 5);
        newWeapon.BlightDamage = UnityEngine.Random.Range(1, 5);
        newWeapon.Charisma = UnityEngine.Random.Range(1, 3);
        newWeapon.Luck = UnityEngine.Random.Range(1, 3);
        newWeapon.Agility = UnityEngine.Random.Range(1, 3);
        newWeapon.Strength = UnityEngine.Random.Range(1, 3);
        newWeapon.Speed = UnityEngine.Random.Range(1, 3);
    }

    private void ChooseWeaponType()
    {
        int randomNumber = UnityEngine.Random.Range(1,4);
        switch (randomNumber)
        {
            case 1:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.BROADSWORD;
                break;
            case 2:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.SHOTGUN;
                break;
            case 3:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.REVOLVER;
                break;
            case 4:
                newWeapon.WeaponType = BaseWeapon.WeaponTypes.LIGHTSHIELD;
                break;
            default:
                Console.WriteLine("Default case");
                break;
        }

    }
}
