using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

 public static bool GameIsPaused = true; 

    void Start()
    {
        ResumeGame(); 
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f; 
        GameIsPaused = false; 
    }
}
