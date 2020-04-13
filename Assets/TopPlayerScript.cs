using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPlayerScript : MonoBehaviour
{
    public bool canJump;
    public bool connectedToCubeBelow;
    public GameObject middlePlayer;
    // Start is called before the first frame update
    void Start()
    {
        canJump = true;
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
            connectedToCubeBelow = true;
            middlePlayer.GetComponent<MiddlePlayerScript>().connectedToCubeBelow = true;
        }
        else
        {
            connectedToCubeBelow = false;
        }
    }
}
