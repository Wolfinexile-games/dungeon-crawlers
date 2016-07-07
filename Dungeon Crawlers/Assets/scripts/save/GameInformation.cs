using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class GameInformation : MonoBehaviour {

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public int SceneID { get; set; }
    public string ActorName { get; set; }
    public int ActorLevel { get; set; }
    public int ActorXP { get; set; }
    public BaseCharacterClass ActorClass { get; set; }
    public int Charisma { get; set; }
    public int Luck { get; set; }
    public int Agility { get; set; }
    public int Strength { get; set; }
    public int Speed { get; set; }
}
