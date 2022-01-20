using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{
    public int[] luckyNumbers = new int [3];

    //shorter way that already contains the numbers:
    //public int[] luckyNumbers = {6,12,18};

    void Start()
    {
        luckyNumbers[0] = 6;
        luckyNumbers[1] = 12;
        luckyNumbers[2] = 18;
    }

    
    void Update()
    {
        
    }
}
