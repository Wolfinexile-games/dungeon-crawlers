using UnityEngine;
using System.Collections;

public class BaseReligious : BaseItem {

    public enum ReligiousTypes
    {
        HOLY,
        SATANIC,
        OCCULT,
        VOODOO
    }

    public enum ReligiousItemTypes
    {
        IDOL,
        VESSEL,
        CHALICE,
        DOLL,
        AMULET
    }

    private ReligiousTypes religiousType;
    private ReligiousItemTypes religiousItemType;
    private int spellEffectID;

    public ReligiousTypes ReligiousType
    {
        get
        {
            return religiousType;
        }

        set
        {
            religiousType = value;
        }
    }

    public ReligiousItemTypes ReligiousItemType
    {
        get
        {
            return religiousItemType;
        }

        set
        {
            religiousItemType = value;
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
}
