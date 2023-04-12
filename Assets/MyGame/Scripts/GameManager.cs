using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] blueFlower, redFlower, whiteFlower, yellowFlower, klee, player;
    public int diceResult, activePlayer;
    public GameObject dice;
    public bool gameOngoing;
    public void DicePressed()
    {
        Debug.Log("dice");
        if (gameOngoing)
        {
            RollDice(activePlayer);
        }

        //Roll dice
        //Show color on dice
        //activate effect
        //update gameboard
        //update player score
        //check if game is over
            //if yes -> declare winner
            //if no -> pass turn to next player
        //from the top
    }

    public void RollDice(int activePlayer)
    {
        //0 = blue
        //1 = red
        //2 = white
        //3 = yellow
        //4 = green
        //5 = black
        diceResult = Random.Range(0, 6);
        if (diceResult == 0)
        {
            //dice.GetComponent<SpriteRenderer>().color = blue;
            if (activePlayer == diceResult)
            {
                player[activePlayer].GetComponent<CountScore>().AddScore(1);
            }
            else
            {
                PassTurn();
            }
        }

        if (diceResult == 1)
        {
            //dice.getComponent<spriteRenderer>().color = red;
            if (activePlayer == diceResult)
            {
                player[activePlayer].GetComponent<CountScore>().AddScore(1);
            }
            else
            {
                PassTurn();
            }
        }

        if (diceResult == 2)
        {
            //dice.getComponent<spriteRenderer>().color = white;
            if (activePlayer == diceResult)
            {
                player[activePlayer].GetComponent<CountScore>().AddScore(1);
            }
            else
            {
                PassTurn();
            }
        }

        if (diceResult == 3)
        {
            //dice.getComponent<spriteRenderer>().color = yellow;
            if (activePlayer == diceResult)
            {
                player[activePlayer].GetComponent<CountScore>().AddScore(1);
            }
            else
            {
                PassTurn();
            }
        }

        if (diceResult == 4)
        {
            //dice.getComponent<spriteRenderer>().color = green;
            player[activePlayer].GetComponent<CountScore>().AddScore(2);
        }

        if (diceResult == 5)
        {
            player[activePlayer].GetComponent<CountScore>().AddScore(-2);
            //dice.getComponent<spriteRenderer>().color = black;
        }
    }

    public void PassTurn()
    {
        if (activePlayer != 3)
        {
            activePlayer++;
        }
        else if (activePlayer == 3)
        {
            activePlayer = 0;
        }
    }

    public void Win()
    {
        gameOngoing = false;
        Debug.Log(activePlayer);
        Debug.Log("Win");
    }
}
