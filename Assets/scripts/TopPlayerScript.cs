﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPlayerScript : MonoBehaviour
{
    public bool canJump;
    public bool syncJump;
    public GameObject middlePlayer;
    // Start is called before the first frame update
    void Start()
    {

        canJump = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
           canJump = true;
        if (collision.gameObject.tag == "MiddlePlayer")
        {
            syncJump = true;
            middlePlayer.GetComponent<MiddlePlayerScript>().syncJump = true;
        }
        else
        {
            syncJump = false;
        }
    }


    //DET E DENNA SOM GÖR ATT DUBBELHOPP INTE SKER; MEN DEN DÖDAR OXÅ HOPP OM ETT SPELAROBJEKT LANDAR PÄ DET HOPPANDE SPELAROBJEKTET.
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    syncJump = true;
    //    canJump = false;
    //}

    public void Animation()
    {
        gameObject.GetComponentInChildren<AnimationScript>().PlayAnimation();
    }

    public void Animation()
    {
        //gameObject.GetComponentInChildren<AnimationScript>().PlayAnimation();    
    }
}
