using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public string sceneToLoad;
    public void RetryButton() 
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
