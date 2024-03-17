using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject optionPanel;
    public GameObject pausePanel;
    public string mainMenu;
    public void resumeButton() 
    {
        pausePanel.SetActive(false);
    }
    public void optionButton() 
    {
        optionPanel.SetActive(true);
    }
    public void mainMenuButton() 
    {
        SceneManager.LoadScene(mainMenu);
    }


}
