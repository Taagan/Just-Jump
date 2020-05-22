using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveState : MonoBehaviour
{
    public float savedSongTimer;
    public float savedPlayerPositionX, savedPlayerPositionY;

    float currentSongTime;
    float currentPlayerPositionX, currentPlayerPositionY;
    ulong playSongAt;
    public GameObject bottomPlayer;
    
    // Start is called before the first frame update

    private void Awake()
    {
        currentSongTime = savedSongTimer;
        playSongAt = Convert.ToUInt64(savedSongTimer);
        gameObject.GetComponentInChildren<AudioSource>().Play(playSongAt);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPlayerPositionX = bottomPlayer.gameObject.transform.position.x;
        currentPlayerPositionY = bottomPlayer.gameObject.transform.position.y;

        currentSongTime += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.O))
        {
            savedSongTimer = currentSongTime;
            savedPlayerPositionX = currentPlayerPositionX;
            savedPlayerPositionY = currentPlayerPositionY;

        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            savedSongTimer = 0;
            savedPlayerPositionX = 0;
            savedPlayerPositionY = 0;
        }
    }
}
