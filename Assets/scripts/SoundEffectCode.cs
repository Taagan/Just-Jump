using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class SoundEffectCode : MonoBehaviour
{

    public AudioSource aS;
    public AudioClip aC;
    public float volume;
    ScoreManager scoreManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreManager = GetComponent<ScoreManager>();
    }

    public void PlaySoundEffect()
    {
        aS.PlayOneShot(aC, volume);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        //Add score
        Destroy(this.gameObject, 2f);
    }

    public void AddScore()
    {

    }
}
