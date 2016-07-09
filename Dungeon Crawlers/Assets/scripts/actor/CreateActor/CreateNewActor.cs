using UnityEngine;

public class CreateNewActor : MonoBehaviour {

    private BaseActor newActor;
    private bool isLycanClass;
    private bool isHighwaymanClass;
    private string actorName = "Your Name";

    public BaseActor NewActor
    {
        get
        {
            return newActor;
        }

        set
        {
            newActor = value;
        }
    }

    // Use this for initialization
    void Start () {
        NewActor = new BaseActor();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnGUI()
    {
        actorName = GUILayout.TextArea(actorName, 16);

        /*
        isLycanClass = GUILayout.Toggle(isLycanClass, "Lycan");
        isHighwaymanClass = GUILayout.Toggle(isHighwaymanClass, "Highwayman");
        */

        if (GUILayout.Toggle(isLycanClass, "Lycan"))
        {
            isLycanClass = true;
            isHighwaymanClass = false;
        }

        if (GUILayout.Toggle(isHighwaymanClass, "Highwayman"))
        {
            isHighwaymanClass = true;
            isLycanClass = false;
        }

        if (GUILayout.Button("Create"))
        {
            if (isLycanClass)
            {
                NewActor.ActorClass = new BaseLycanClass();
            }
            else if (isHighwaymanClass)
            {
                NewActor.ActorClass = new BaseHighwaymanClass();
            }
            newActor.DungeonsCleared = 0;
            newActor.ActorName = actorName;
            newActor.ActorLevel = 1;
            newActor.ActorXP = 0;
            newActor.Charisma = newActor.ActorClass.Charisma;
            newActor.Luck = newActor.ActorClass.Luck;
            newActor.Agility = newActor.ActorClass.Agility;
            newActor.Strength = newActor.ActorClass.Strength;
            newActor.Speed = newActor.ActorClass.Speed;
            //PlayerState.Instance.localPlayerData.SceneID = Application.loadedLevel;
            SaveData.Instance.dungeonsCleared = newActor.DungeonsCleared;
            SaveData.Instance.actorName = newActor.ActorName;
            SaveData.Instance.actorClass = newActor.ActorClass;
            SaveData.Instance.actorLevel = newActor.ActorLevel;
            SaveData.Instance.actorXP = newActor.ActorXP;
            SaveData.Instance.charisma = newActor.Charisma;
            SaveData.Instance.luck = newActor.Luck;
            SaveData.Instance.agility = newActor.Agility;
            SaveData.Instance.strength = newActor.Strength;
            SaveData.Instance.speed = newActor.Speed;

            SaveLoad.Save();
            
            Debug.Log(newActor.ActorName);
            Debug.Log(newActor.ActorClass);


        }

        if (GUILayout.Button("Load"))
        {
            SaveLoad.Load();

            newActor.DungeonsCleared = SaveData.Instance.dungeonsCleared;
            newActor.ActorName = SaveData.Instance.actorName;
            newActor.ActorLevel = SaveData.Instance.actorLevel;
            newActor.ActorClass = SaveData.Instance.actorClass;
            newActor.ActorXP = SaveData.Instance.actorXP;
            newActor.Charisma = SaveData.Instance.charisma;
            newActor.Luck = SaveData.Instance.luck;
            newActor.Agility = SaveData.Instance.agility;
            newActor.Strength = SaveData.Instance.strength;
            newActor.Speed = SaveData.Instance.speed;

            Debug.Log(newActor.ActorName);
            Debug.Log(newActor.ActorClass);
            

            //int whichScene = GlobalControl.Instance.LocalCopyOfData.SceneID;

            //Application.LoadLevel(whichScene);
        }
    }
}
