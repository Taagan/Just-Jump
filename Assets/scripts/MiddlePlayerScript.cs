using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePlayerScript : MonoBehaviour
{
    public bool canJump;
    public bool syncJump;
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
        if (collision.gameObject.tag == "JumpRefresh")
        {
            canJump = true;
        }
        if (collision.gameObject.tag == "BottomPlayer")
        {
            gameObject.GetComponent<Rigidbody>().velocity = collision.gameObject.GetComponent<Rigidbody>().velocity;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
            
        if (collision.gameObject.tag == "BottomPlayer")
        {
            syncJump = true;
            canJump = true;
            gameObject.GetComponent<Rigidbody>().velocity = collision.gameObject.GetComponent<Rigidbody>().velocity;
        }
        //Kommer endast användas om man vill att kuberna inte ska hoppa tsm såvida de är connectade;
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
            syncJump = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        syncJump = true;
        //canJump = false;
        if (collision.gameObject.tag == "BottomPlayer")
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
