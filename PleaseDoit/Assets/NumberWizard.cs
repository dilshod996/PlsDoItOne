using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
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
        Debug.Log("Welcome to my World!!");
        Debug.Log("We have max in min points");
        Debug.Log("Assigned max is: " + max);
        Debug.Log("Assigned min is: " + min);
        Debug.Log("Calculated number is: " + guess);
        max++;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            min = guess;
            GuessGame();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            max = guess;
            GuessGame();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I am genius");
            StartGame();
        }
    }
    void GuessGame()
    {
        guess = (min + max) / 2;
        Debug.Log("it is lower or higher than we expected:..." + guess);
    }
}
