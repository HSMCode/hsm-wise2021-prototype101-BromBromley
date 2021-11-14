using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTest : MonoBehaviour
{
    public int firstVariable = 10;
    public int secondVariable = 12;
    public int thirdVariable = 38;

    public int variableSum;

    public string sumText = "Zusammen ergibt das: ";
    void Start()
    {
        variableSum = (firstVariable + secondVariable + thirdVariable) / 3;
        Debug.Log(sumText + variableSum);
    }

    void Update()
    {
        
    }
}
