using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPlayerScript : MonoBehaviour
{
    public bool canJump;
    public bool syncJump;
    public GameObject middlePlayer;
    public bool jumpCD;
    private int timer = 0;
    // Start is called before the first frame update



    public bool CanJump { get { return canJump; } set { canJump = value; } }

    void Start()
    {
        canJump = true;
        jumpCD = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "JumpRefresh")
        {
            canJump = true;
        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
           canJump = true;

    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        syncJump = true;
        if (collision.gameObject.tag == "MiddlePlayer")
        {
            jumpCD = true;
            canJump = false;
        }
        else if (collision.gameObject.tag == "Ground")
        {
            jumpCD = true;
            canJump = false;
        }
    }

    private void Update()
    {
        if (jumpCD)
        {
            timer++;
            if (timer >= 10)
            {
                jumpCD = false;
            }
        }
    }
    public void Animation()
    {
        //aktivera om du vill ha animationer
        //gameObject.GetComponentInChildren<AnimationScript>().PlayAnimation();
    } 
}
