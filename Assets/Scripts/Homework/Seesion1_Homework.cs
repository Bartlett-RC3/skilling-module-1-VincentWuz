using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.TerrainAPI;

public class Seesion1_Homework : MonoBehaviour
{
    public int myFirstWholeNmuber = 1;
    private int mySecondWholeNumber = 99;

    public float myFirstLongdecimaNumber = 0.554654f;

    public double myFirstLongdecimalNumber = 0.5554654554654d;

    private string myFirstWords = "Hello World!";
    public string mySeocndWord = "Hello";

    private bool myFirstBollen = true;
    public bool mySecondBollen = false;

    public int[] myWholeNumbersCollection = new int[5];
    public float[] myDecimalNumbersCollection = { 1.0f, 2.0f, 3.0f, 4.0f };


    public List<int> myFirstIntList = new List<int>();

    private float CalculatorSum(float _FirstNumber, float _SecondNumber)
    {
        float SumResult = _FirstNumber + _SecondNumber;
        return SumResult;

    }

  







    // Start is called before the first frame update
    void Start()
    {
       
        float SumResult = CalculatorSum(myFirstWholeNmuber, mySecondWholeNumber);
        Debug.Log("Adding two numbers result is: " + SumResult.ToString());

        myDecimalNumbersCollection[0] = 2.8f; 
        float SumResult2 = CalculatorSum(myDecimalNumbersCollection[0], myDecimalNumbersCollection[2]);

        myFirstIntList.Add(3);
        myFirstIntList.Add(9);
        myFirstIntList[0] = 5;
        myFirstIntList[1] = 12;

        Debug.Log(myFirstIntList[0]);

        
       

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
