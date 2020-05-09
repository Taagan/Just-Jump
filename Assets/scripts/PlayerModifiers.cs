using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModifiers : MonoBehaviour
{

    public GameObject gameMaster;
    public int newSpeedValue;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameMaster.GetComponent<MovementPlayer>().speed = newSpeedValue;
        }
    }
}
