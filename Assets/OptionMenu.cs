using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionMenu : MonoBehaviour
{
    public GameObject optionpanel;
    public void quitButton() 
    {
        optionpanel.SetActive(false);
    }
}
