using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePlayerScript : MonoBehaviour
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
        if (collision.gameObject.tag == "BottomPlayer" || collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
        if (collision.gameObject.tag == "BottomPlayer") //Kommer endast användas om man vill att kuberna inte ska hoppa tsm såvida de är connectade;
        {
            connectedToCubeBelow = true;
        }
    }
}
