using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

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
        actorName = GUILayout.TextArea(actorName);

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
            newActor.ActorLevel = 1;
            newActor.ActorXP = 0;
            newActor.Charisma = newActor.ActorClass.Charisma;
            newActor.Luck = newActor.ActorClass.Luck;
            newActor.Agility = newActor.ActorClass.Agility;
            newActor.Strength = newActor.ActorClass.Strength;
            newActor.Speed = newActor.ActorClass.Speed;
            //PlayerState.Instance.localPlayerData.SceneID = Application.loadedLevel;
            PlayerState.Instance.localPlayerData.ActorName = newActor.ActorName;
            PlayerState.Instance.localPlayerData.ActorClass = newActor.ActorClass;
            PlayerState.Instance.localPlayerData.ActorLevel = newActor.ActorLevel;
            PlayerState.Instance.localPlayerData.ActorXP = newActor.ActorXP;
            PlayerState.Instance.localPlayerData.Charisma = newActor.Charisma;
            PlayerState.Instance.localPlayerData.Luck = newActor.Luck;
            PlayerState.Instance.localPlayerData.Agility = newActor.Agility;
            PlayerState.Instance.localPlayerData.Strength = newActor.Strength;
            PlayerState.Instance.localPlayerData.Speed = newActor.Speed;

            GlobalControl.Instance.SaveData();

            Debug.Log(newActor.ActorName);
            Debug.Log(newActor.ActorClass);


        }

        if (GUILayout.Button("Load Game"))
        {
            GlobalControl.Instance.LoadData();
            GlobalControl.Instance.IsSceneBeingLoaded = true;

            Debug.Log(newActor.ActorName);
            Debug.Log(newActor.ActorClass);

            //int whichScene = GlobalControl.Instance.LocalCopyOfData.SceneID;

            //Application.LoadLevel(whichScene);
        }
    }
}
