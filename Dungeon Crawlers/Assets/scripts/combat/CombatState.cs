using UnityEngine;
using System.Collections;

public class CombatState : MonoBehaviour {

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        PLAYERANIMATE,
        ENEMYCHOICE,
        ENEMYANIMATE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

	// Use this for initialization
	void Start () {
        currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
        switch (currentState)
        {
            case (BattleStates.START):
                //INITIATE AND SETUP THE BATTLE
                break;
            case (BattleStates.PLAYERCHOICE):
                //PLAYER'S TURN
                break;
            case (BattleStates.PLAYERANIMATE):
                //ANIMATE PLAYER MOVE
                break;
            case (BattleStates.ENEMYCHOICE):
                //AI'S TURN
                break;
            case (BattleStates.ENEMYANIMATE):
                //ANIMATE ENEMY MOVE
                break;
            case (BattleStates.LOSE):
                //PLAYER LOSES
                break;
            case (BattleStates.WIN):
                //PLAYER WINS
                break;
            default:
                break;
        }
	}

    void OnGui()
    {
        if (currentState == BattleStates.START)
        {
            currentState = BattleStates.PLAYERCHOICE;
            
        }
    }
}
