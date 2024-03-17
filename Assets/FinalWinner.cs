using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FinalWinner : MonoBehaviour
{
    public string mainMenu;
   public void MainButton() 
    {
        SceneManager.LoadScene(mainMenu);
    }
}
