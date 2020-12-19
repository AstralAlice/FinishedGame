using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
   
    private float score=0;
    public TextMeshProUGUI scoreText;
    bool stop;
  
    void Start()
    {
       
       

    }

    // Update is called once per frame
    void Update()
    {
        //check if gameover is triggered using gameOver and stop once it is
        bool gameOver = FindObjectOfType<DetectCollisions>().gameOver;
        stop = gameOver;
         if (stop != true) { 
            score += Time.time;

            scoreText.text = "Score: " + score;
         }
    }
}
