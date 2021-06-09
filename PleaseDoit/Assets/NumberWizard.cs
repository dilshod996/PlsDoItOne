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
        Debug.Log("Welcome to my World!!");
        Debug.Log("We have max in min points");
        Debug.Log("Assigned max is: " + max);
        Debug.Log("Assigned min is: " + min);
        Debug.Log("Calculated number is: " + guess);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down key was pressed");
        }
    }
}
