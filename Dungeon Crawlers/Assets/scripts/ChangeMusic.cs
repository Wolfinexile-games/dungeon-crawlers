using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour
{

    public AudioClip gamePlayMusic;


    private AudioSource source;


    // Use this for initialization
    void Awake()
    {
        source = GetComponent<AudioSource>();
    }


    void OnLevelWasLoaded(int level)
    {
        if (level == 2)
        {
            source.clip = gamePlayMusic;
            source.Play();
        }

    }
}