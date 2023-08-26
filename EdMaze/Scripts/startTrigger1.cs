using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startTrigger1 : MonoBehaviour
{
    private void OnTriggerEnter() 
    {
        //To restart our scenes
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);    
    }
}
