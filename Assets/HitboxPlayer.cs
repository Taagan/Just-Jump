﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitboxPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "BottomPlayer" && collision.gameObject.tag != "MiddlePlayer" && collision.gameObject.tag != "TopPlayer")
        {
            SceneManager.LoadScene(0);

        }
    }
}
