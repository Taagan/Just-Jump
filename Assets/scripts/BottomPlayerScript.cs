using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomPlayerScript : MonoBehaviour
{
    public bool canJump;
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
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
    }

    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Ground")
    //    {
    //        canJump = false;
    //    }
    //}

    public void Animation()
    {
        gameObject.GetComponentInChildren<AnimationScript>().PlayAnimation();
    }
}
