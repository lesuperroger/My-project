using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string levelToLoad = "MainMenu";
   public void quitButton() 
    { 
        Application.Quit();
    }
    public void optionButton()
    { 

    }
    public void playButton() 
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
