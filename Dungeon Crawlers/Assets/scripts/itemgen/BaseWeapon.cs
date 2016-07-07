using UnityEngine;
using System.Collections;

public class BaseWeapon : BaseItemStat {

	public enum WeaponTypes
    {
        SHORTSWORD,
        BROADSWORD,
        LONGSWORD,
        SHORTBOW,
        HUNTINGBOW,
        LONGBOW,
        SHOTGUN,
        LEVERACTIONRIFLE,
        REVOLVER,
        QUARTERSTAFF,
        GLAIVE,
        BUCKLER,
        LIGHTSHIELD,
        HEAVYSHIELD
    }

    private WeaponTypes weaponType;
    private int spellEffectID;
    private int healthDamage;
    private int bleedChance;
    private int blightChance;
    private int bleedDamage;
    private int blightDamage;

    public WeaponTypes WeaponType
    {
        get
        {
            return weaponType;
        }

        set
        {
            weaponType = value;
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

    public int HealthDamage
    {
        get
        {
            return healthDamage;
        }

        set
        {
            healthDamage = value;
        }
    }

    public int BleedChance
    {
        get
        {
            return bleedChance;
        }

        set
        {
            bleedChance = value;
        }
    }

    public int BlightChance
    {
        get
        {
            return blightChance;
        }

        set
        {
            blightChance = value;
        }
    }

    public int BleedDamage
    {
        get
        {
            return bleedDamage;
        }

        set
        {
            bleedDamage = value;
        }
    }

    public int BlightDamage
    {
        get
        {
            return blightDamage;
        }

        set
        {
            blightDamage = value;
        }
    }
}
