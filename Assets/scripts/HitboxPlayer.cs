using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System;

public class HitboxPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "BonusPoint")
        {
            collision.gameObject.GetComponent<SoundEffectCode>().PlaySoundEffect();
            GUIscript.coinsTaken++;
        }
        else if (collision.gameObject.tag == "LevelEnd")
        {
            GUIscript.ChangeStateOfGame(WinOrLose.won);
        }
        else if (collision.gameObject.tag!="Player" && collision.gameObject.tag != "SafeBlock" /*&& collision.gameObject.tag !="BonusPoint"*/)
        {
            //SceneManager.LoadScene(0);
            Time.timeScale = 0;
            GUIscript.ChangeStateOfGame(WinOrLose.lost);
        }
    }
}
