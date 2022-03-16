using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void LoadStart()
      { 
         SceneManager.LoadScene("Easy");
       }
    // public void LoadScene(string level)
    //   { 
    //      SceneManager.LoadScene(level);
    //    }
}
