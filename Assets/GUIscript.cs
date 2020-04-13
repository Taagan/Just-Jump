using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIscript : MonoBehaviour
{
  
   public GameObject guiParentObject;
   static AudioSource audioSource;

    bool menuIsOpen;
    //float savedSpeed = MovementPlayer.thisInstance.speed;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = Camera.main.GetComponent<AudioSource>();
        menuIsOpen = false;
        if (guiParentObject.activeInHierarchy)
        {
            guiParentObject.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseOrUnpause();
            
        }


        if (menuIsOpen)
        {
            Time.timeScale = 0;
            guiParentObject.SetActive(true);
            audioSource.Pause();
            // Camera.main.GetComponent<AudioSource>().Pause();
        }
        else
        {
            Time.timeScale = 1;
            guiParentObject.SetActive(false);
            audioSource.UnPause();
            //Camera.main.GetComponent<AudioSource>().Play();
        }
    }

   public void PauseOrUnpause()
    {
        if (menuIsOpen)
        {
            menuIsOpen = false;
        }
        else
        {
            menuIsOpen = true;
        }
    }
}
