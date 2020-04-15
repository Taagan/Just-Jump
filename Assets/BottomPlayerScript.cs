using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomPlayerScript : MonoBehaviour
{
    public bool canJump;
    public GameObject playerBottom;
  

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
        if (collision.gameObject.tag == "Ground")
        {
            canJump = true;
        }
        //Debug.Log("Object Y : " +(transform.position.y - 0.49f));
        //Debug.Log("Collider  " + collision.collider.transform.position.y+ "  ColliderTag " + collision.gameObject.tag);
        
    }
}
