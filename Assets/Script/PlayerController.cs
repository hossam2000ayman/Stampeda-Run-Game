using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;

    public float xRange = 40f;


    public GameObject projectilePrefab;

    public float zMin;
    public float zMax;
    public float verticalInput;

    public Transform projectileSpawnPoint;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, zMin);
        }
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x,
            transform.position.y, zMax);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);



        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, projectileSpawnPoint.position,
            projectilePrefab.transform.rotation);
        }
    }
}
