using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerState : MonoBehaviour
{

    public static PlayerState Instance;

    //TUTORIAL
    public GameInformation localPlayerData = new GameInformation();

    void Awake()
    {
        if (Instance == null)
            Instance = this;

        if (Instance != this)
            Destroy(gameObject);

        GlobalControl.Instance.Player = Instantiate(gameObject);
    }

    //At start, load data from GlobalControl.
    void Start()
    {
        localPlayerData = GlobalControl.Instance.savedPlayerData;
    }

    void Update()
    {

    }

}