using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPlayerScript : MonoBehaviour
{
    public bool canJump;
    public bool connectedToCubeBelow;
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
            GetComponent<MiddlePlayerScript>().connectedToCubeBelow = true;
        }
        else
        {
            connectedToCubeBelow = false;
        }
    }
}
