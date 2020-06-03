using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePlayerScript : MonoBehaviour
{
    public bool canJump;
    public bool touchingTop,touchingBottom;
    public bool jumpCD,velocityShare = true;
    private int timer = 0;
    // Start is called before the first frame update

    public bool TouchingTop { get {return touchingTop; } set { touchingTop = value; } }
    public bool TouchingBottom { get { return touchingBottom; } set { touchingBottom = value; } }

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
        if (collision.gameObject.tag == "BottomPlayer")
        {
            canJump = true;
            touchingBottom = true;
        }
        //Kommer endast användas om man vill att kuberna inte ska hoppa tsm såvida de är connectade;
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    { 
        if (collision.gameObject.tag == "BottomPlayer")
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
        //Aktivera om du vill ha animations
        //gameObject.GetComponentInChildren<AnimationScript>().PlayAnimation();
    }

}
