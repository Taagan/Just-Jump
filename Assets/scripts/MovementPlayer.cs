using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour
{
    

    public GameObject playerTop, playerMiddle, playerBottom;

    public float speed;
    public float jumpForce;
    Rigidbody2D rbBottom, rbMiddle, rbTop, rbGameMaster;
    public enum Mode { normal, boostMode }
    Mode currentMode;
    public bool BoostMode = false;
    // Use this for initialization
    void Start()
    {
        rbBottom = playerBottom.GetComponent<Rigidbody2D>();
        rbMiddle = playerMiddle.GetComponent<Rigidbody2D>();
        rbTop = playerTop.GetComponent<Rigidbody2D>();
        rbGameMaster = GetComponent<Rigidbody2D>();
        //Make this cleaner
        if (BoostMode == true)
        {
            currentMode = Mode.boostMode;
        }
        else
        {
            currentMode = Mode.normal;
        }
    }

    // Update is called once per frame
    void Update()
    {
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
        if (currentMode == Mode.boostMode)
        {
            BoostedJump();
        }
        else
        {
            NormalJump();
        }

        rbTop.velocity = new Vector2(speed, rbTop.velocity.y);                 // <spelet funkar utan dessa pga if satserna ovanför
        rbMiddle.velocity = new Vector2(speed, rbMiddle.velocity.y);           // <spelet funkar utan dessa
        rbBottom.velocity = new Vector2(speed, rbBottom.velocity.y);

        rbGameMaster.velocity = new Vector2(speed, 0);

        //Debug 
        //Debug.Log("Connected A:" +playerTop.GetComponent<TopPlayerScript>().syncJump  +"S:"+
        //    playerMiddle.GetComponent<MiddlePlayerScript>().syncJump + "\n Can Jump" + 
        //   "A:"+ playerMiddle.GetComponent<MiddlePlayerScript>().canJump + " S:"+
        //   playerTop.GetComponent<TopPlayerScript>().canJump);
    }

    private void Jump(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(speed, jumpForce);    //kan lägga 0 istället för speed, samma sak händer
    }


    private void BoostedJump()
    {
        
        if (Input.GetKeyDown(KeyCode.D) && playerBottom.GetComponent<BottomPlayerScript>().canJump == true)
        {
            if (playerMiddle.GetComponent<MiddlePlayerScript>().canJump == true && playerTop.GetComponent<TopPlayerScript>().canJump == true)
            {
                ////För att göra så att de övre kuberna kan hoppa separat när de inte är connectade till kuben under. Funkar men blir problematiskt att klara av banan
                if (playerTop.GetComponent<TopPlayerScript>().syncJump == true && playerMiddle.GetComponent<MiddlePlayerScript>().syncJump == true)
                {
                    Jump(rbTop);
                    GUIscript.jumpCounterTop++;
                }
                if (playerMiddle.GetComponent<MiddlePlayerScript>().syncJump == true)
                {
                    Jump(rbMiddle);
                    GUIscript.jumpCounterMiddle++;
                }
                GUIscript.jumpCounterBottom++;
                Jump(rbBottom);
                playerBottom.GetComponent<BottomPlayerScript>().canJump = false;
            }
            else if (playerMiddle.GetComponent<MiddlePlayerScript>().canJump == true && playerTop.GetComponent<TopPlayerScript>().canJump == false)
            {
                Jump(rbMiddle);
                Jump(rbBottom);
                GUIscript.jumpCounterBottom++;
                GUIscript.jumpCounterMiddle++;
                playerBottom.GetComponent<BottomPlayerScript>().canJump = false;

            }
            else
            {
                Jump(rbBottom);
                GUIscript.jumpCounterBottom++;
                playerBottom.GetComponent<BottomPlayerScript>().canJump = false;

            }
        }

        if (Input.GetKeyDown(KeyCode.S) && playerMiddle.GetComponent<MiddlePlayerScript>().canJump == true)
        {
            if (playerTop.GetComponent<TopPlayerScript>().canJump == true)
            {
                Jump(rbTop);
                Jump(rbMiddle);
                GUIscript.jumpCounterTop++;
                GUIscript.jumpCounterMiddle++;
                playerMiddle.GetComponent<MiddlePlayerScript>().canJump = false;
                playerMiddle.GetComponent<MiddlePlayerScript>().syncJump = false;
            }
            else
            {
                Jump(rbMiddle);
                GUIscript.jumpCounterMiddle++;
                playerMiddle.GetComponent<MiddlePlayerScript>().canJump = false;
                playerMiddle.GetComponent<MiddlePlayerScript>().syncJump = false;
                playerMiddle.GetComponent<MiddlePlayerScript>().Animation();

            }

        }
        if (Input.GetKeyDown(KeyCode.A) && playerTop.GetComponent<TopPlayerScript>().canJump == true)
        {
            Jump(rbTop);
            GUIscript.jumpCounterTop++;
            playerTop.GetComponent<TopPlayerScript>().canJump = false;
            playerTop.GetComponent<TopPlayerScript>().syncJump = false;
            playerTop.GetComponent<TopPlayerScript>().Animation();
        }
    }

    private void NormalJump()
    {
        if (Input.GetKeyDown(KeyCode.D) && playerBottom.GetComponent<BottomPlayerScript>().canJump == true)
        {
            Jump(rbTop);
            Jump(rbMiddle);
            Jump(rbBottom);
            playerBottom.GetComponent<BottomPlayerScript>().canJump = false;
        }
        if (Input.GetKeyDown(KeyCode.S) && playerMiddle.GetComponent<MiddlePlayerScript>().canJump == true)
        {
            Jump(rbTop);
            Jump(rbMiddle);
            playerMiddle.GetComponent<MiddlePlayerScript>().canJump = false;
        }
        if (Input.GetKeyDown(KeyCode.A) && playerTop.GetComponent<TopPlayerScript>().canJump == true)
        {
            Jump(rbTop);
            playerTop.GetComponent<TopPlayerScript>().canJump = false;
        }
    }
}
