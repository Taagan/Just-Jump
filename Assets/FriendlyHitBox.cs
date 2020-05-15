using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendlyHitBox : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
    }
    private void Awake()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "BottomPlayerFriendlyHitBox")
        {
            GetComponent<MiddlePlayerScript>().TouchingBottom = true;
            Debug.Log("1");

        }

        if (collision.gameObject.tag == "FriendlyHitBox")
        {
            GetComponent<MiddlePlayerScript>().TouchingTop = false;

            Debug.Log("3");
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "FriendlyHitBox")
        {
            GetComponent<MiddlePlayerScript>().TouchingTop = true;
            Debug.Log("1");
        }
        else
        {
            GetComponent<MiddlePlayerScript>().TouchingTop = false;
            Debug.Log("2");

        }
        if (collision.gameObject.tag == "BottomPlayerFriendlyHitBox")
        {
            GetComponent<MiddlePlayerScript>().TouchingBottom = true;
            Debug.Log("3");

        }
        else
        {
            GetComponent<MiddlePlayerScript>().TouchingBottom = false;
            Debug.Log("4");

        }
    }
}
