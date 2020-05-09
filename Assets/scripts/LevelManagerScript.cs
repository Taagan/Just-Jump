 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelManagerScript : MonoBehaviour
{
    public static int currentLevelIndex, previousLevelIndex;

    [SerializeField]
    private Text author, songTitle, percentageText;
    public Image angledProgressBar, blackBackgroundProgressBar;
    [SerializeField]

    float progressBarStartPosX, progressBarFinalPosX;
    string songTitleString, authorString;
    [SerializeField]

    float totalSecondsInSong, progressBarXSpeed, distanceToTravel;
    Vector3 startPos, endPos;
    public GameObject endOfLevelMarker,timer;

    public bool inLevelSelect;
    private float startTime;

    GameObject gameMaster;
    // Start is called before the first frame update
    void Start()
    {
        currentLevelIndex = SceneManager.GetActiveScene().buildIndex;
        if (!inLevelSelect)
        {
            GetCurrentSong();
            // 0% in progressbar
            startPos = angledProgressBar.transform.position;
            //100% in progressbar
            endPos = blackBackgroundProgressBar.transform.position;
            startTime = Time.time;
            distanceToTravel = Vector3.Distance(gameObject.transform.position, endOfLevelMarker.transform.position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float currentSpeed = gameMaster.GetComponent<MovementPlayer>().speed;
        if (!inLevelSelect)
        {
            float distCovered = (Time.time - startTime) * currentSpeed;
            float fractionOfJourney = distCovered / distanceToTravel;
            float t = gameObject.transform.position.x / endOfLevelMarker.transform.position.x;
            float percent = t * 100f;
            percentageText.text = percent.ToString("0.") + "%";
            if (!GUIscript.menuIsOpen)
            {
                angledProgressBar.transform.position = Vector3.Lerp(startPos, endPos, t);
            }
        }
    }

    public void LoadLevel(int levelIndex)
    {
        previousLevelIndex = currentLevelIndex;
        currentLevelIndex = levelIndex;
        SceneManager.LoadScene(levelIndex);
        GUIscript.resetStats();
    }

    public void ReloadPreviousLevel()
    {
        SceneManager.LoadScene(previousLevelIndex);
    }

    public void ReloadCurrentLevel()
    {

        SceneManager.LoadScene(currentLevelIndex);
        GUIscript.resetStats();

    }

    public static void ReloadCurrentUsingStatic()
    {
        SceneManager.LoadScene(currentLevelIndex);
        GUIscript.resetStats();
    }

    public void GetCurrentSong()
    {
        songTitle.text = Camera.main.GetComponent<AudioSource>().clip.name;
        totalSecondsInSong = Camera.main.GetComponent<AudioSource>().clip.length;
    }

    public void Quit()
    {
        Application.Quit();
    }

}
