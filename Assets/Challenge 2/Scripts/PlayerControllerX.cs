using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnTime = 5.0f;
    private float spawnInterval = 3.5f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog


        GenerateDog();
    }

    private void GenerateDog()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            InvokeRepeating("GenerateDog", spawnTime, spawnInterval);
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
