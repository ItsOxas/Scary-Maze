using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public string NextLevelName;
    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name.Contains("Player"))
        {
            SceneManager.LoadScene(NextLevelName);
        }
    }

}

