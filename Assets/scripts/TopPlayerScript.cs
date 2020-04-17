using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPlayerScript : MonoBehaviour
{
    public bool canJump;
    public bool syncJump;
    public GameObject middlePlayer;
    public Animator ani;
    // Start is called before the first frame update
    void Start()
    {
        canJump = true;
        ani.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
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
    private void OnCollisionExit2D(Collision2D collision)
    {
        syncJump = true;
    }

    public void Animation()
    {
        ani.enabled = true;
        ani.Play("FlopAnimation");
    }
}
