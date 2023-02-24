using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A red ball
/// </summary>
public class RedBall : Ball
{
    override protected void PrintMessage()
    {
        Debug.Log("I'm a red ball");
    }
}
