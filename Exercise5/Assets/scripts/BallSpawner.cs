using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A ball spawner
/// </summary>
public class BallSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject ball;

    [SerializeField]
    GameObject ballGreen;

    [SerializeField]
    GameObject ballBlue;

    Timer spawnTimer;

    int duration = 1;
    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = GetComponent<Timer>();
        spawnTimer.Duration = duration;
        spawnTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer.Finished)
        {
            spawnTimer.Duration = duration;
            spawnTimer.Run();

            GameObject[] balls =
            {
                ball,
                ballGreen,
                ballBlue,
            };

            int option = Random.Range(0, balls.Length);

            GameObject chosenBall = Instantiate(balls[option]) as GameObject;
            //Instantiate(chosenBall);
        }
    }
}
