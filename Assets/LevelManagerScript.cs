using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManagerScript : MonoBehaviour
{
  public static int currentLevelIndex = 0;

    [SerializeField]
    private Text author, songTitle, percentageText;
    public Image angledProgressBar, blackBackgroundProgressBar;
    [SerializeField]

    float progressBarStartPosX, progressBarFinalPosX;
    string songTitleString, authorString;
    [SerializeField]

    float totalSecondsInSong, xSpeed, distanceToTravel;
    Vector3 startPos, endPos;
    float testSeconds = 30;
    public GameObject testObject;

    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        GetCurrentSong();

        startPos = angledProgressBar.transform.position;
        endPos = blackBackgroundProgressBar.transform.position;
        startTime = Time.time;
        distanceToTravel = Vector3.Distance(gameObject.transform.position, testObject.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        float distCovered = (Time.time - startTime) * 7;
        float fractionOfJourney = distCovered / distanceToTravel;
       float t = gameObject.transform.position.x / testObject.transform.position.x;
        float percent = t * 100f;
        percentageText.text = percent.ToString("0.") + "%";
        if (!GUIscript.menuIsOpen)
        {
            angledProgressBar.transform.position = Vector3.Lerp(startPos, endPos, t);
        }
        
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
