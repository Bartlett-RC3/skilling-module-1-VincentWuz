using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session2_Homework : MonoBehaviour
{
    string[] colours = { "red", "green", "blue", "yellow", "fuchsia" };

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(colours[1]);
        for (int counter = 0; counter < colours.Length; counter = counter + 1)
        {
            Debug.Log("The current color at pos" + counter);
            Debug.Log("" + colours[counter]);
        }
        int sumOfoddNumbers = 0;
        for (int i = 1; i < 100; i = i + 2)
        {
            sumOfoddNumbers += i;
        }
        Debug.Log("all odd numbers to 100 added togheter is :" + sumOfoddNumbers);

        foreach (string currentColour in colours)
        {
            Debug.Log("Going over the rainbow with" + currentColour);

        }

        int whileCounter = 0;
        string rainbow = "Rainbow colours:";
        while (whileCounter < colours.Length)
        {
            rainbow += colours[whileCounter];
            whileCounter += 2;
        }
        Debug.Log(rainbow);

        for (int i = 0; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log("Whole number:" + i);

            }
            else
            {
                Debug.Log("Odd number" + i);
            }

        }

        bool question1Answer = true;
        bool question2Answer = true;
        bool question3Answer = false;

        if (question1Answer && question2Answer)
        {
            Debug.Log("Both answers are true");

        }

        if (question1Answer || question3Answer)
        {
            Debug.Log("One of the answers is true");
        }

        if (question1Answer || question2Answer || question3Answer)
        {

        }

        if(question1Answer == true)
        {
            if(question2Answer == true)
            {
                if(question3Answer == false)
                {

                }
            }
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
