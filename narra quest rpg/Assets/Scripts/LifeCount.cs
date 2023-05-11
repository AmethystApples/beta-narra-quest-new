﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{

    public Image[] lives;
    public int livesRemaining;

    //3 lives - 3 images (0, 1, 2)
    //2 lives - 2 images (0, 1, [2])

    private void LoseLife()
    {
        //if no lives - do nothing
        if (livesRemaining == 0)
        {
            return;
        }

        //decrease livesRemaining
        livesRemaining--;
        //hide life icon
        lives[livesRemaining].enabled = false;
        //0 lives -> lose game
        if(livesRemaining == 0)
        {
            Debug.Log(" You have lost ");
        }
    }
    private void Update()
    {
        //testing lose life
        if (Input.GetKeyDown(KeyCode.Return))
        {
            LoseLife();
        }
    }
}
