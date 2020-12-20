using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    public float xRange = 20;
    public float zRange = 20;
    public GameObject projectilePrefab;

    // Start is called before the first frame update
  
    void Start()
    {
        
    }

    
    
    // Update is called once per frame
    void Update()
    {
        //find out if power is usable and if it is destroy all bullets currently spawned
        bool power = FindObjectOfType<DetectCollisions> ().powerReady;
        if (Input.GetKeyDown(KeyCode.Space) && power == true)
        {
            GameObject[] death = GameObject.FindGameObjectsWithTag("bullet");
            foreach (GameObject bullet in death)
                Destroy(bullet);
         
        }

        //horizontal movement
        if (transform.position.x < -20)
        {
            transform.position = new Vector3(-20, transform.position.y, transform.position.z);

        }
        if (transform.position.x > 20)
        {
            transform.position = new Vector3(20, transform.position.y, transform.position.z);

        }
        horizontalInput = Input.GetAxis("Horizontal");


        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //forward movement
        if (transform.position.z < 2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 2);

        }
        if (transform.position.z > 15)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 15);

        }
        verticalInput = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
       

        

    }
}
