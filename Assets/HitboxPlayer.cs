using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System;

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
        if (collision.gameObject.tag == "BonusPoint")
        {
            collision.gameObject.GetComponent<SoundEffectCode>().PlaySoundEffect();

        }
        else if (collision.gameObject.tag!="Player" && collision.gameObject.tag != "SafeBlock" /*&& collision.gameObject.tag !="BonusPoint"*/)
        {
            SceneManager.LoadScene(0);

        }

    }
}
