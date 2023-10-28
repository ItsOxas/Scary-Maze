using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public string LevelName;
    public void ButtonPressed()
    { 
        LoadNextLevel();
    }


    void LoadNextLevel()
    {
        SceneManager.LoadScene(LevelName);
    }
}
