using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectLevel()
    {
        //Swap scene to "SelectLevel"
        Debug.Log("hej");
        SceneManager.LoadScene(1);
    }
    public void Level01()
    {
        SceneManager.LoadScene(2);

    }
    public void Options()
    {
        //Swap scene to "Options"
    }
    public void QuitTheGame()
    {
        Application.Quit();
        //Exit the game
    }
}
