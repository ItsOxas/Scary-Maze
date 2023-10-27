using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FollowCursor : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
    }
    void OnCollisionStay2D(Collision2D coll)
    {
       if (coll.gameObject.name.Contains("Path"))
       {
            SceneManager.LoadScene("Menu");   
       }
    }

}
