using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange: MonoBehaviour
{

    public void RestartGame()
    {
       
        SceneManager.LoadScene("Game");
        Debug.Log("i'm epic");
    }
}
