using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour
{
    void eventTrigger(Collider changeScene)
    {
       // if (changeScene.gameObject.CompareTag("Player"))
       // {
            new WaitForSeconds(3);
            SceneManager.LoadScene("Level 2");
        Debug.Log("Moved to level 2");

       // }
    }
}
