using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfPound : MonoBehaviour
{
    private float topBound = 30f;
    private float lowerBound = -10f;
    private float sideBound = 30;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        //if objects goes past the player view in the game , remove that object
        if(transform.position.z > topBound)
        {
            
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            gameManager.AddLives(-1);
            Destroy(gameObject);
        }

        else if (transform.position.x > sideBound)
        {
            gameManager.AddLives(-1);

            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            gameManager.AddLives(-1);

            Destroy(gameObject);
        }
    }


}

