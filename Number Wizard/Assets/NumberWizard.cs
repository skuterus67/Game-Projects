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

        Debug.Log("Welcome to the number wizard");
        Debug.Log("Please choose a number for me to guess");
        Debug.Log("The minimal value should be " + min);
        Debug.Log("The maximal value should be " + max);
        Debug.Log("Is your number bigger than " + guess);
        Debug.Log("Push Up - higher, Push Down - lower, Push Enter - correct");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("So your number is higher than " + guess + "...");
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("So your number is lower than " + guess + "...");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Yay! I knew it! It was " + guess + "!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it " + guess + "?");
    }
}
