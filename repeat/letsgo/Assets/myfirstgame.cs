using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myfirstgame : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("here our lowest and highest number is: " + max);
        Debug.Log("here our lowest and highest number is: " + min);
        Debug.Log("lets calculate avarage of the numbers: " + guess);
        max++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            max = guess;
            GameNewguess();
            Debug.Log("you want high number: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            min = guess;
            GameNewguess();
            Debug.Log("You pressed down key: " + guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("enter key war pressed and start game new ");
            StartGame();
        }
    }
    void GameNewguess()
    {
        guess = (max + min) / 2;
    }
}
