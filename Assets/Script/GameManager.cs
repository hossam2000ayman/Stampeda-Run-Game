using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int score = 0;
    private int lives = 1;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    public void AddLives(int value)
    {
        lives += value;
        if (lives <= 0)
        {
            Debug.Log("Game Over");
            lives = 0;
        }
        Debug.Log("Lives = " + lives);
    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score = " + score);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
