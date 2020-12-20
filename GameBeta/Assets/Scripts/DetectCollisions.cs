using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollisions : MonoBehaviour
{
    public AudioClip Boom;
    public AudioClip Blip;
    private AudioSource PlayerAudio;
    public TextMeshProUGUI GameOver;
    public Button RestartButton;
    public bool gameOver = false;
    public int hp = 3;
    public bool powerReady=true;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        PlayerAudio = GetComponent<AudioSource>();
        //set power to be unusable after being used and play a sound effect
        if (Input.GetKeyDown(KeyCode.Space) && powerReady == true)
        {
            powerReady = false;
            this.PlayerAudio.PlayOneShot(this.Blip, 1.5f);
        }
    }
    
    public void OnTriggerEnter(Collider other)
    {
        //sets power as ready to be used by the player and plays a sound effect
        if (other.gameObject.CompareTag("Powerup")){
            Destroy(other.gameObject);
            powerReady = true;
            this.PlayerAudio.PlayOneShot(this.Blip, 1.0f);
        }

        else if (hp == 0){
            //destroy all bullets on screen
            GameObject[] death = GameObject.FindGameObjectsWithTag("bullet");
            foreach (GameObject bullet in death)
                Destroy(bullet);
            //destroy player and play boom
            this.PlayerAudio.PlayOneShot(this.Boom, 1.0f);
            Destroy(gameObject);
     
            Debug.Log("Game Over");

            //display game over and halt spawning
            GameOver.gameObject.SetActive(true);
            RestartButton.gameObject.SetActive(true);
            gameOver = true;
   


        }
        else if (hp >= 1)
        {
            //destroy the object you hit
            Destroy(other.gameObject);
            //lose health
            hp = hp - 1;
            //play sound effect
            this.PlayerAudio.PlayOneShot(this.Boom, 1.0f);
        }
    }
}
