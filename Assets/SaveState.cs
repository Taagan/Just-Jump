using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveState : MonoBehaviour
{
    public float savedSongTimer;
    public Vector3 bottomSavedPlayerPosition, middleSavedPlayerPosition, topSavedPlayerPosition;
    Vector3 savedCameraPosition;
    float currentSongTime;
    Vector3 bottomCurrentPlayerPosition, middleCurrentPlayerPosition, topCurrentPlayerPosition;
    public ulong delay;
    public GameObject bottomPlayer,middlePlayer,topPlayer;
    public Camera camera;
    public AudioSource aS;
    int savedCameraIndex;
    // Start is called before the first frame update

    private void Awake()
    {
        savedCameraPosition = new Vector3(0, 0, -1);
        bottomPlayer.gameObject.transform.position = new Vector2(bottomPlayer.gameObject.transform.position.x, bottomPlayer.gameObject.transform.position.y);
        middlePlayer.gameObject.transform.position = new Vector2(middlePlayer.gameObject.transform.position.x, middlePlayer.gameObject.transform.position.y);
        topPlayer.gameObject.transform.position = new Vector2(topPlayer.gameObject.transform.position.x, topPlayer.gameObject.transform.position.y);
        currentSongTime = savedSongTimer;
        aS.time = savedSongTimer;
        aS.Play(delay);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bottomCurrentPlayerPosition = bottomPlayer.gameObject.transform.position;
        middleCurrentPlayerPosition = middlePlayer.gameObject.transform.position;
        topCurrentPlayerPosition = topPlayer.gameObject.transform.position;

        currentSongTime += Time.deltaTime *44100;
        if (Input.GetKeyDown(KeyCode.O))
        {
            bottomSavedPlayerPosition = bottomCurrentPlayerPosition;
            middleSavedPlayerPosition = middleCurrentPlayerPosition;
            topSavedPlayerPosition = topCurrentPlayerPosition;
            savedSongTimer = currentSongTime;
            savedCameraPosition = camera.transform.position;
            savedCameraIndex = camera.GetComponent<PathFollowerScript>().index;
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            savedSongTimer = 0;
        }
    }

    public void RestartFromSave()
    {
        currentSongTime = savedSongTimer;
        bottomPlayer.transform.position = bottomSavedPlayerPosition;
        middlePlayer.transform.position = middleSavedPlayerPosition;
        topPlayer.transform.position = topSavedPlayerPosition;
        camera.transform.position = savedCameraPosition;
        camera.GetComponent<PathFollowerScript>().index = savedCameraIndex;
        currentSongTime = savedSongTimer;
        aS.time = savedSongTimer;
        aS.Play(delay);
    }
}
