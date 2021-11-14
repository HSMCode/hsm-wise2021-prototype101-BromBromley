using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    private int numberOne = 1; 
    private int numberTwo = 2;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            numberOne = numberOne + numberTwo;
            Debug.Log(numberOne);

            if (numberOne == 5)
            {
            Debug.Log("This if-statement was true: 5");
            }
            else if (numberOne >= 10)
            {
            Debug.Log("This if-statement was true: >= 10");
            }
            else
            {
            Debug.Log("This if-statement was false.");
            }
        }


    }
}
