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

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
           canJump = true;
        }
    }
}
