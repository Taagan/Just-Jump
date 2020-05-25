using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveState : MonoBehaviour
{
    public float savedSongTimer;
    public Vector3 bottomSavedPlayerPosition, middleSavedPlayerPosition, topSavedPlayerPosition,bottomStartPosition,middleStartPosition,topStartPosition, cameraStartPosition;
    Vector3 savedCameraPosition;
    float currentSongTime,pathTraveled,pathTraveledStartValue;
    Vector3 bottomCurrentPlayerPosition, middleCurrentPlayerPosition, topCurrentPlayerPosition;
    public ulong delay;
    public GameObject bottomPlayer,middlePlayer,topPlayer, gameMaster;
    public Camera camera;
    public AudioSource aS;
    int savedCameraIndex;
    // Start is called before the first frame update
    public bool saveOn;
    private void Awake()
    {
        if (saveOn)
        {
            cameraStartPosition = gameMaster.transform.position;
            pathTraveledStartValue = gameMaster.GetComponent<PathFollowerScript>().decimalOfWayThere;
            bottomStartPosition = new Vector2(bottomPlayer.gameObject.transform.position.x, bottomPlayer.gameObject.transform.position.y);
            middleStartPosition = new Vector2(middlePlayer.gameObject.transform.position.x, middlePlayer.gameObject.transform.position.y);
            topStartPosition = new Vector2(topPlayer.gameObject.transform.position.x, topPlayer.gameObject.transform.position.y);
            currentSongTime = savedSongTimer;
            aS.time = savedSongTimer;
        }
        aS.Play(delay);
    }

    void Start()
    {
        if (saveOn)
        {
            GetComponent<HitboxPlayer>().LevelEditor = true;
            savedCameraPosition = cameraStartPosition;
        }
        else
        {
            GetComponent<HitboxPlayer>().LevelEditor = false;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (saveOn)
        {


            bottomCurrentPlayerPosition = bottomPlayer.gameObject.transform.position;
            middleCurrentPlayerPosition = middlePlayer.gameObject.transform.position;
            topCurrentPlayerPosition = topPlayer.gameObject.transform.position;

            currentSongTime += Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.O))
            {
                bottomSavedPlayerPosition = bottomCurrentPlayerPosition;
                middleSavedPlayerPosition = middleCurrentPlayerPosition;
                topSavedPlayerPosition = topCurrentPlayerPosition;
                savedSongTimer = currentSongTime;
                savedCameraPosition = gameMaster.transform.position;
                savedCameraIndex = gameMaster.GetComponent<PathFollowerScript>().index;
                pathTraveled = gameMaster.GetComponent<PathFollowerScript>().decimalOfWayThere;
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                savedSongTimer = 0;
                savedCameraPosition = cameraStartPosition;
                bottomSavedPlayerPosition = bottomStartPosition;
                middleSavedPlayerPosition = middleCurrentPlayerPosition;
                topSavedPlayerPosition = topCurrentPlayerPosition;
                savedCameraIndex = gameMaster.GetComponent<PathFollowerScript>().index = 0;
                pathTraveled = pathTraveledStartValue;
                ResetScene();
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                RestartFromSave();
            }
        }
    }

    public void RestartFromSave()
    {
        gameMaster.GetComponent<PathFollowerScript>().index = savedCameraIndex;
        aS.time = savedSongTimer;
        bottomPlayer.transform.position = bottomSavedPlayerPosition;
        middlePlayer.transform.position = middleSavedPlayerPosition;
        topPlayer.transform.position = topSavedPlayerPosition;
        gameMaster.transform.position = savedCameraPosition;
        gameMaster.GetComponent<PathFollowerScript>().decimalOfWayThere = pathTraveled;
        currentSongTime = savedSongTimer;
    }

    public void ResetScene()
    {
        gameMaster.GetComponent<PathFollowerScript>().index = savedCameraIndex;
        gameMaster.GetComponent<PathFollowerScript>().decimalOfWayThere = pathTraveledStartValue;
        currentSongTime = savedSongTimer;
        aS.time = savedSongTimer;
        bottomPlayer.transform.position = bottomSavedPlayerPosition;
        middlePlayer.transform.position = middleSavedPlayerPosition;
        topPlayer.transform.position = topSavedPlayerPosition;
        gameMaster.transform.position = cameraStartPosition;
    }
}
