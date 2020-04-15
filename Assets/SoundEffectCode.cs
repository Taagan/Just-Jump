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

    // Update is called once per frame
    void Update()
    {
        
    }


    public void PlaySoundEffect()
    {
        aS.PlayOneShot(aC, volume);
        gameObject.renderer.enabled = false;
        //scoreManager.collectedBonuses += 1;
        Destroy(this.gameObject, 2f);
    }

    public void AddScore()
    {

    }
}
