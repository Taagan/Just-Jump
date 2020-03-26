using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPlayer : MonoBehaviour {

    public GameObject playerBlue, playerYellow, playerGreen;
    public float speed;
    public float jumpForce;
    Rigidbody2D rbGreen, rbYellow, rbBlue, rbGameMaster;
    // Use this for initialization
    void Start()
    {
        rbGreen = playerGreen.GetComponent<Rigidbody2D>();
        rbYellow = playerYellow.GetComponent<Rigidbody2D>();
        rbBlue = playerBlue.GetComponent<Rigidbody2D>();
        rbGameMaster = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.D))
        {
            Jump(rbBlue);
            Jump(rbYellow);
            Jump(rbGreen);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Jump(rbBlue);
            Jump(rbYellow);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Jump(rbBlue);
        }

        rbYellow.velocity = new Vector2(speed, rbYellow.velocity.y);
        rbGreen.velocity = new Vector2(speed, rbGreen.velocity.y);
        rbBlue.velocity = new Vector2(speed, rbBlue.velocity.y);

        rbGameMaster.velocity = new Vector2(speed, 0);
    }

    private void Jump(Rigidbody2D rb)
    {
        rb.velocity = new Vector2(speed, jumpForce);
    }
}
