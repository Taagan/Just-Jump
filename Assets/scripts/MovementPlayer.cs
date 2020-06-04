using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    public enum Mode
    {
        normal,debug
    }

    public GameObject playerTop, playerMiddle, playerBottom,bottomSprite,middleSprite,topSprite;
    Rigidbody2D rbBottom, rbMiddle, rbTop, rbGameMaster;
    public float speed, jumpForce,bufferTimerD,bufferTimerS,bufferTimerA;
    public static float speedCopy;
    private bool jumpBufferActive,bottomBufferActive,middleBufferActive,topBufferActive;
    public Mode mode;
    // Use this for initialization
    void Start()
    {
        speedCopy = speed;
        rbBottom = playerBottom.GetComponent<Rigidbody2D>();
        rbMiddle = playerMiddle.GetComponent<Rigidbody2D>();
        rbTop = playerTop.GetComponent<Rigidbody2D>();
        rbGameMaster = GetComponent<Rigidbody2D>();
        switch (mode)
        {
            case Mode.normal:
                break;
            case Mode.debug:
                rbBottom.simulated = false;
                rbMiddle.simulated = false;
                rbTop.simulated = false;
                jumpForce = 0;

                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        BufferMechanic();
        speedCopy = speed;
        #region player alignment
        if (playerTop.transform.position.x != playerBottom.transform.position.x)
        {
            playerTop.transform.position = new Vector3(playerBottom.transform.position.x, playerTop.transform.position.y, playerTop.transform.position.z);
        }
        if (playerMiddle.transform.position.x != playerBottom.transform.position.x)
        {
            playerMiddle.transform.position = new Vector3(playerBottom.transform.position.x, playerMiddle.transform.position.y, playerMiddle.transform.position.z);
        }
        #endregion
        BoostedJump();

        rbBottom.velocity = new Vector2(speed, rbBottom.velocity.y);
        speedCopy = speed;

       rbGameMaster.velocity = new Vector2(speed, 0);
        switch (mode)
        {
            case Mode.normal:
                break;
            case Mode.debug:
                debugMovement();
                break;
        }
    }

    public void debugMovement()
    {
        bottomSprite.transform.position = new Vector2(rbGameMaster.position.x, playerBottom.transform.position.y);
        middleSprite.transform.position = new Vector2(rbGameMaster.position.x, playerMiddle.transform.position.y);
        topSprite.transform.position = new Vector2(rbGameMaster.position.x, playerTop.transform.position.y);
    }

    private void Jump(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(speed, jumpForce);    //speed blir horizentala vikeln       
    }

    public void FullJump()
    {
        if (playerBottom.GetComponent<BottomPlayerScript>().canJump)
        {
            //if (playerMiddle.GetComponent<MiddlePlayerScript>().touchingBottom)
            //{
                //if (playerMiddle.GetComponent<MiddlePlayerScript>().touchingTop)
                //{
                //    Jump(rbBottom);
                //    Jump(rbMiddle);
                //    Jump(rbTop);


                //    GUIscript.jumpCounterBottom++;
                //    playerBottom.GetComponent<BottomPlayerScript>().canJump = false;
                //}
                //else if(!playerMiddle.GetComponent<MiddlePlayerScript>().touchingTop)
                //{
                //    Jump(rbMiddle);
                //    Jump(rbBottom);
                //    GUIscript.jumpCounterBottom++;
                //    playerBottom.GetComponent<BottomPlayerScript>().canJump = false;
                //}
                //}

                Jump(rbBottom);
                GUIscript.jumpCounterBottom++;
                playerBottom.GetComponent<BottomPlayerScript>().canJump = false;
            
        }
        else if (Input.GetKeyDown(KeyCode.D) && !playerBottom.GetComponent<BottomPlayerScript>().canJump)
        {
            bottomBufferActive = true;
        }
    }
    public void MiddleJump()
    {
        if (playerMiddle.GetComponent<MiddlePlayerScript>().canJump == true)
        {
            //if (playerMiddle.GetComponent<MiddlePlayerScript>().touchingTop)
            //{
            //    Jump(rbTop);
            //    Jump(rbMiddle);
            //    GUIscript.jumpCounterMiddle++;
            //    playerMiddle.GetComponent<MiddlePlayerScript>().canJump = false;
            //}
            
            
            Jump(rbMiddle);
            GUIscript.jumpCounterMiddle++;
            playerMiddle.GetComponent<MiddlePlayerScript>().canJump = false;

            
        }
        else if (Input.GetKeyDown(KeyCode.S) && !playerMiddle.GetComponent<MiddlePlayerScript>().canJump)
        {
            middleBufferActive = true;
        }
    }
    public void TopJump()
    {
        if (playerTop.GetComponent<TopPlayerScript>().canJump)
        {
            Jump(rbTop);
            GUIscript.jumpCounterTop++;
            playerTop.GetComponent<TopPlayerScript>().canJump = false;
            playerTop.GetComponent<TopPlayerScript>().Animation();
        }
        else if (Input.GetKeyDown(KeyCode.A) && !playerTop.GetComponent<TopPlayerScript>().canJump)
        {
            topBufferActive = true;
        }
    }
    private void BoostedJump()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            FullJump();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            MiddleJump();

        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            TopJump();
        }
    }
    private void BufferMechanic()
    {
        
        if (bottomBufferActive)
        {
            bufferTimerD++;
            if (playerBottom.GetComponent<BottomPlayerScript>().canJump)
            {
                FullJump();
                bottomBufferActive = false;
                bufferTimerD = 0;
            }
            if (bufferTimerD >= 100)
            {
                bufferTimerD = 0;
                bottomBufferActive = false;
            }
        }
        if (middleBufferActive)
        {
            bufferTimerS++;
            if (playerMiddle.GetComponent<MiddlePlayerScript>().canJump)
            {
                MiddleJump();
                TopJump();
                middleBufferActive = false;
                bufferTimerS = 0;
                Debug.Log("a");
            }
            if (bufferTimerS >= 100)
            {
                bufferTimerS = 0;
                middleBufferActive = false;
            }
        }
        if (topBufferActive)
        {
            bufferTimerS++;
            if (playerTop.GetComponent<TopPlayerScript>().canJump)
            {
                TopJump();
                topBufferActive = false;
                bufferTimerS = 0;
                Debug.Log("a");
            }
            if (bufferTimerA >= 100)
            {
                bufferTimerA = 0;
                topBufferActive = false;
            }
        }



    }
}
