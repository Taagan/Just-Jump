using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum WinOrLose
{
    won, lost, playing
}
public class GUIscript : MonoBehaviour
{
    public static int jumpCounterTop = 0, jumpCounterMiddle = 0, jumpCounterBottom = 0, jumpCounterTotal = 0, coinsTaken = 0;
    public GameObject pauseMenuParent;
    public GameObject topBlockText, middleBlockText, bottomBlockText, totalText, rankText, jumpsTitleText;
    public GameObject WinMenuParent, winMenuReportCard;
    public GameObject LoseMenuParent,timer;
   static AudioSource audioSource;
    Color purple, yellow;
   public static WinOrLose currentState;
    [SerializeField]
    public static bool menuIsOpen = false;

    //float savedSpeed = MovementPlayer.thisInstance.speed;
    // Start is called before the first frame update
    void Start()
    {
        purple = new Color(174, 0, 255);
        yellow = new Color(255, 240, 0);
        audioSource = Camera.main.GetComponent<AudioSource>();
        menuIsOpen = false;
        if (pauseMenuParent.activeInHierarchy)
        {
            pauseMenuParent.SetActive(false);
        }
        currentState = WinOrLose.playing;
    }

    // Update is called once per frame
    void Update()
    {
        jumpCounterTotal = jumpCounterTop + jumpCounterMiddle + jumpCounterBottom;
        
        switch (currentState)
        {
            case WinOrLose.won:

                Time.timeScale = 0;
                WinMenuParent.SetActive(true);

                updateColorOnText(purple);

                topBlockText.GetComponent<Text>().text ="Top: "  + jumpCounterTop.ToString();
                middleBlockText.GetComponent<Text>().text = "Middle: " + jumpCounterMiddle.ToString();
                bottomBlockText.GetComponent<Text>().text = "Bottom: " + jumpCounterBottom.ToString();
                totalText.GetComponent<Text>().text = "Total: " + jumpCounterTotal.ToString();
                rankText.GetComponent<Text>().text = "Rank: " + (coinsTaken / jumpCounterTotal).ToString();
                audioSource.Pause();
                break;

            case WinOrLose.lost:

                Time.timeScale = 0;
                timer.GetComponent<Timer>().timer = 0;
                LoseMenuParent.SetActive(true);
                audioSource.Pause();

                winMenuReportCard.transform.parent = LoseMenuParent.transform;

                updateColorOnText(yellow);

                topBlockText.GetComponent<Text>().text = "Top: " + jumpCounterTop.ToString();
                middleBlockText.GetComponent<Text>().text = "Middle: " + jumpCounterMiddle.ToString();
                bottomBlockText.GetComponent<Text>().text = "Bottom: " + jumpCounterBottom.ToString();
                totalText.GetComponent<Text>().text = "Total: " + jumpCounterTotal.ToString();
                rankText.GetComponent<Text>().text = "Rank: Failed";
                break;
            case WinOrLose.playing:
                WinMenuParent.SetActive(false);
                LoseMenuParent.SetActive(false);

                if (Input.GetKeyDown(KeyCode.Escape))
                {
                    PauseOrUnpause();
                }

                if (menuIsOpen)
                {
                    Time.timeScale = 0;
                    pauseMenuParent.SetActive(true);
                    audioSource.Pause();
                    // Camera.main.GetComponent<AudioSource>().Pause();
                }
                else
                {
                    Time.timeScale = 1;
                    pauseMenuParent.SetActive(false);
                    audioSource.UnPause();
                    //Camera.main.GetComponent<AudioSource>().Play();
                }
                break;
            default:
                break;
        }
    }

   public void PauseOrUnpause()
    {
        if (menuIsOpen)
        {
            menuIsOpen = false;
        }
        else
        {
            menuIsOpen = true;
        }
   }

    public static void ChangeStateOfGame(WinOrLose wonOrLost)
    {
        currentState = wonOrLost;
    }

    public static void resetStats()
    {
        GUIscript.coinsTaken = 0;
        GUIscript.jumpCounterBottom = 0;
        GUIscript.jumpCounterMiddle = 0;
        GUIscript.jumpCounterTop = 0;       
    }

    private void updateColorOnText(Color c)
    {
        jumpsTitleText.GetComponent<Text>().color = c;
        topBlockText.GetComponent<Text>().color = c;
        middleBlockText.GetComponent<Text>().color = c;
        bottomBlockText.GetComponent<Text>().color = c;
        totalText.GetComponent<Text>().color = c;
        rankText.GetComponent<Text>().color = c;
        winMenuReportCard.GetComponent<Image>().color = c;
    }
}
