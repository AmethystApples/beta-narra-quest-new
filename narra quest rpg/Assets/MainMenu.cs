﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        //THIS IS WHAT OPENS WHEN "PLAY" IS HIT
        SceneManager.LoadScene("ScuttleTest"); //THIS CAN BE CHANGED TO LOAD THE NEXT SCENE IN THE INDEX (index is file > build Settings)
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void SendToOptions(){
        SceneManager.LoadScene("OptionsMenu");
    }

    public void SendToCredits(){
        SceneManager.LoadScene("Credits");
    }
}
