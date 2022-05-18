using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    Gnome[] _gnomes;
    [SerializeField] string _nextLevelName;

    void OnEnable()
    {
        _gnomes = FindObjectsOfType<Gnome>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GnomesAllDead())
            GoToNextLevel();
    }

    void GoToNextLevel()
    {
        Debug.Log("Go to next level" + _nextLevelName);
        SceneManager.LoadScene(_nextLevelName);
    }

    bool GnomesAllDead()
    {
        foreach (var gnome in _gnomes)
        {
            if (gnome.gameObject.activeSelf)
                return false;
        }

        return true;
    }
}
