using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePlayerScript : MonoBehaviour
{
    public bool canJump;
    public bool syncJump;
    // Start is called before the first frame update
    void Start()
    {
        canJump = true;
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
        if (collision.gameObject.tag == "BottomPlayer")
        {
            syncJump = true;
        }
        //Kommer endast användas om man vill att kuberna inte ska hoppa tsm såvida de är connectade;
        if (collision.gameObject.tag == "Ground")
        {
            syncJump = false;
        }
    }
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    syncJump = true;
    //    canJump = false;
    //}
    public void Animation()
    {
        gameObject.GetComponentInChildren<AnimationScript>().PlayAnimation();
    }

}
