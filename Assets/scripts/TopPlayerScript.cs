using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopPlayerScript : MonoBehaviour
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }
}
