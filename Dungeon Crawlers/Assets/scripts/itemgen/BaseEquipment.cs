using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseItemStat {

	public enum EquipmentTypes
    {
        HEAD,
        NECK,
        BACK,
        CHEST,
        HANDS,
        FINGERS,
        BELT,
        LEGS,
        FEET
    }

    private EquipmentTypes equipmentType;
    private int spellEffectID;

    public EquipmentTypes EquipmentType
    {
        get
        {
            return equipmentType;
        }

        set
        {
            equipmentType = value;
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
