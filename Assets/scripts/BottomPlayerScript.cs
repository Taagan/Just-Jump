using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomPlayerScript : MonoBehaviour
{
    public bool canJump;
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
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground" && !canJump && !jumpCD )
        {
            canJump = true;
        }
        if (collision.gameObject.tag == "SafeBlock" && !canJump && !jumpCD)
        {
            canJump = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
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
            if (timer >= 0)
            {
                jumpCD = false;
            }
        }
    }

    public void CheckMiddlePlayer()
    {

    }


    public void Animation()
    {
        gameObject.GetComponentInChildren<AnimationScript>().PlayAnimation();
    }
}
