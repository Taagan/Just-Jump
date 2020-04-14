using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManagerScript : MonoBehaviour
{
  public static int currentLevelIndex = 0;

    [SerializeField]
    private Text author, songTitle;
    public GameObject angledProgressBar, blackBackgroundProgressBar;
   public string songTitleString, authorString;
   public float totalSecondsInSong;
    // Start is called before the first frame update
    void Start()
    {
        GetCurrentSong();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(int levelIndex)
    {
        currentLevelIndex = levelIndex;
        SceneManager.LoadScene(levelIndex);
    }

    public void ReloadCurrentLevel()
    {
        SceneManager.LoadScene(currentLevelIndex);
    }

    public void GetCurrentSong()
    {
        songTitle.text = Camera.main.GetComponent<AudioSource>().clip.name;
        totalSecondsInSong = Camera.main.GetComponent<AudioSource>().clip.length;
    }
}
