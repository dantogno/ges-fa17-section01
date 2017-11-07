using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField]
    string sceneToLoad;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Action"))
            {
                SceneManager.LoadScene(sceneToLoad);
            }
        }
    }
}
