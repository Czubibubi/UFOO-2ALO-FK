using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    //typ nazwe()
    //{
    //return 
    //}
    //int string float void

    public void LoadStartScene()
    {
        SceneManager.LoadScene(1);

    }
    public void Quit()
    {
      Application.Quit();

    }
    public void LoadNextScene()
    {
        int currentIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentIndex+1);
    }


     
}
