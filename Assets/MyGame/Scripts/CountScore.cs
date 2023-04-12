using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountScore : MonoBehaviour
{
    public int score;
    public GameManager manager;
    public void AddScore(int scoreAdd)
    {
        score += scoreAdd;
        if (score <= 0)
        {
            score = 0;
        }
        UpdateScoreIndicator();
    }

    public void UpdateScoreIndicator()
    {
        //I'm doing this later
        CheckForWin();
    }

    public void CheckForWin()
    {
        if (score >= 10)
        {
            manager.Win();
        }
        else
        {
            manager.PassTurn();
        }
    }
}
