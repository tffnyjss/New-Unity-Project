using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
   
    public void Pause()
    {
        SceneManager.LoadScene(9);
    }
    public void Resume()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Home()
    {
        
        SceneManager.LoadScene(0);
    }
    
}
