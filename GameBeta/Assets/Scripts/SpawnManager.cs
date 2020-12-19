using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    private float startDelay = 2;
    private float spawnInterval = .1f;
    public GameObject[] bullets;
    public GameObject powerup;
    private float spawnRangeX = 20;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("BulletSpawn", startDelay, spawnInterval);


    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, Random.Range(0, spawnRangeX));
        int spawn = Random.Range(1, 200 );
        if (spawn == 2)
        {
            Instantiate(powerup, spawnPos, powerup.transform.rotation);
            
        }
    }
    void BulletSpawn()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnRangeX);
        Vector3 spawnPos2 = new Vector3(spawnRangeX, 1, Random.Range(-spawnRangeX, spawnRangeX));
        Vector3 spawnPos3 = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, 0);
        Vector3 spawnPos4 = new Vector3(1, 1, Random.Range(-spawnRangeX, spawnRangeX));
        bool gameOver = FindObjectOfType<DetectCollisions>().gameOver;
        if (Time.time <= 30 && gameOver != true)
        { 
            Instantiate(bullets[0], spawnPos, bullets[0].transform.rotation);
        }
        else if (Time.time <= 60 && Time.time >=30 && gameOver != true)
        {
            Instantiate(bullets[0], spawnPos, bullets[0].transform.rotation);
            Instantiate(bullets[1], spawnPos2, bullets[1].transform.rotation);
        }
        else if (Time.time <= 90 && Time.time >= 60 && gameOver != true)
        {
            Instantiate(bullets[0], spawnPos, bullets[0].transform.rotation);
            Instantiate(bullets[1], spawnPos2, bullets[1].transform.rotation);
            Instantiate(bullets[2], spawnPos3, bullets[2].transform.rotation);
        }
        else if (Time.time >= 90 && gameOver != true)
        {
            Instantiate(bullets[0], spawnPos, bullets[0].transform.rotation);
            Instantiate(bullets[1], spawnPos2, bullets[1].transform.rotation);
            Instantiate(bullets[2], spawnPos3, bullets[2].transform.rotation);
            Instantiate(bullets[3], spawnPos4, bullets[3].transform.rotation);
        }
    }
}
