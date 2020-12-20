using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Power : MonoBehaviour
{


    public TextMeshProUGUI powerText;
   

    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        //find out if ability is ready and display on screen if it is
        bool power = FindObjectOfType<DetectCollisions>().powerReady;
        if (power == true)
        {
            powerText.text = "Ability Ready(spacebar) ";
        }
        else { powerText.text = "Not Ready"; }
    }
}
