using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{

    public static int currentLevelIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
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
}
