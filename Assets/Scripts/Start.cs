using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Start : MonoBehaviour
{
    Gnome[] _gnomes;
    [SerializeField] string _nextLevelName;


    void OnMouseDown()

    {
            GoToNextLevel();
    }

    void GoToNextLevel()
    {
        Debug.Log("Go to next level" + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    }

   
}
