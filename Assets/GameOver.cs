using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public string sceneToLoad;
    public string sceneMainMenu;
    public void RetryButton() 
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    public void MainMenuButton() 
    {
        SceneManager.LoadScene(sceneMainMenu);
    }
}
