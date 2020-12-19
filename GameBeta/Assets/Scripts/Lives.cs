using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lives : MonoBehaviour
{
    public TextMeshProUGUI livesText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //grab hp from DetectCollisions each frame
        int lives = FindObjectOfType<DetectCollisions>().hp;
        //set lives display to display current lives each frame
        livesText.text = "Lives: " + lives ;
    }
}
