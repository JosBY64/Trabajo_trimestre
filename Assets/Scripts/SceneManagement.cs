using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Video;

public class SceneManagement : MonoBehaviour
{
   

public void Play()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SceneLv1");
    }

 public void Exit()
    {
        Application.Quit();
    }

    public void Resume()
    {
        //Time.timeScale = 1f;
        
    }

    public void Credits()
    {
        SceneManager.LoadScene("EscenaCreditos");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }

}
