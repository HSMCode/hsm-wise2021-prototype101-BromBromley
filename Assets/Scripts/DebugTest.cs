using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugTest : MonoBehaviour
{
    // This script is just a test to try out the different debug log methods

    void Awake()
    {
        // Debug.LogWarning("Greetings, I am a debug warning, but you can ignore me.");
    }
    void Start()
    {
        Debug.Log("Hello, I'm a debug log!");
        Debug.LogError("Salvete, error sum. Hoc modo temptamen est.");
    }

    void Update()
    {
        Debug.Log("Hi, I'm a debug log that appears every frame!");
        Debug.LogWarning("Good day, I am a warning that appears every frame.");
    }
}
