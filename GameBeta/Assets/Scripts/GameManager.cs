using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Scenes : MonoBehaviour
{
   

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("i'm epic");
    }
}
