using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
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

        Debug.Log("Welcome to number wizard, yo");
        Debug.Log("Pick a number");
        Debug.Log("Highest number is: " + max);
        Debug.Log("Lowest Number is:" + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = Higher, Push Down = Lower, Push Enter = Correct");
        max += 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I am a genious!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("is it higher or lower than..." + guess);
    }
}
