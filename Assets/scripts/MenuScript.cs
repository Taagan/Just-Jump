using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MenuScript : MonoBehaviour
{

    public static int currentLevelIndex = 0;
    public Toggle instantRestartToggle;
   public static bool instantRestart;
    // Start is called before the first frame update
    void Start()
    {
        instantRestartToggle.onValueChanged.AddListener(delegate
        { InstantRestart(); } );
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
    public void Options()
    {
        //Swap scene to "Options"
        SceneManager.LoadScene(2);

    }
    public void QuitTheGame()
    {
        Application.Quit();
        //Exit the game
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(currentLevelIndex);
    }

    public static void InstantRestart()
    {
        if (instantRestart)
        {
            instantRestart = false;
        }
        else
        {
            instantRestart = true;
        }
        Debug.Log(instantRestart);
    }

}
