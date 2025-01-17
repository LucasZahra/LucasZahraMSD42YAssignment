﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    int score = 0;


    void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numerOfGameSessions = FindObjectsOfType<GameSession>().Length;

        if (numerOfGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;

        if(score >= 100)
        {
            Level.LoadWinner();
        }
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
