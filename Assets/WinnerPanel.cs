using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class WinnerPanel : MonoBehaviour
{
    public string sceneToLoad;
    public void NextButton() 
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
