using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{

    private GameManager gameManager;

    public Behaviour obj;

    private int numberOfLives = 1;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Game Over");
            
            gameManager.AddLives(--numberOfLives);

            Destroy(gameObject);
        }
        else if (other.CompareTag("Animal"))
        {
            // gameManager.AddScore(5);
            other.GetComponent<AnimalHunger>().FeedAnimal(++numberOfLives);
            Destroy(gameObject);
            
        }


    }
}
