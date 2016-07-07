using UnityEngine;
using System.Collections;

public class TestGUI : MonoBehaviour {

    private BaseCharacterClass class1 = new BaseHighwaymanClass();
    private BaseCharacterClass class2 = new BaseLycanClass();

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        GUILayout.Label(class1.Charisma.ToString());
        GUILayout.Label(class1.Luck.ToString());
        GUILayout.Label(class1.Agility.ToString());
        GUILayout.Label(class1.Strength.ToString());
        GUILayout.Label(class1.Speed.ToString());

        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        GUILayout.Label(class2.Charisma.ToString());
        GUILayout.Label(class2.Luck.ToString());
        GUILayout.Label(class2.Agility.ToString());
        GUILayout.Label(class2.Strength.ToString());
        GUILayout.Label(class2.Speed.ToString());
    }
}
