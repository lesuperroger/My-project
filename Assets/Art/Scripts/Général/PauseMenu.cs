using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausePanel;
    public string mainMenu;
    public void resumeButton() 
    {
        Debug.Log("panneloff");
        pausePanel.SetActive(false);
    }
    public void optionButton() 
    {
        Debug.Log("optionson");
    }
    public void mainMenuButton() 
    {
        Debug.Log("main");
        SceneManager.LoadScene(mainMenu);
    }


}
