using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d20Script : MonoBehaviour
{
    private string winMessage = "You win! You're number was: ";
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int diceRoll = Random.Range(1, 20);
            Debug.Log(diceRoll);

            if (diceRoll == 3 || diceRoll == 7 || diceRoll == 13)
            {
                Debug.Log(winMessage + diceRoll);
            }
        }
    }
}
