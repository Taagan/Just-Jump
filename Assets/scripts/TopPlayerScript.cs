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
    void Start()
    {
        canJump = true;
        jumpCD = false;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MiddlePlayer")
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity;
        }
        if (collision.gameObject.tag == "JumpRefresh")
        {
            canJump = true;
        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
           canJump = true;
        if (collision.gameObject.tag == "MiddlePlayer")
        {
            syncJump = true;
            middlePlayer.GetComponent<MiddlePlayerScript>().syncJump = true;
            gameObject.GetComponent<Rigidbody2D>().velocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity;

        }
        else
        {
            syncJump = false;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        syncJump = true;
        if (collision.gameObject.tag == "MiddlePlayer")
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
        //gameObject.GetComponentInChildren<AnimationScript>().PlayAnimation();
    }

   
}
