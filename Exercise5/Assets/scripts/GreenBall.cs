using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A green ball
/// </summary>
public class GreenBall : Ball
{
    // Start is called before the first frame update
    override protected void Start()
    {
        impulseVector = new Vector2(0, 5);
        base.Start();
    }

    protected override void PrintMessage()
    {
        //print("I am a green ball");
        Debug.Log("I am a green ball");
    }
}
