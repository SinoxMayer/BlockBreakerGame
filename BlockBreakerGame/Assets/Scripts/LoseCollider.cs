using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseCollider : MonoBehaviour
{
    public void LoadGameOverScene()
    {
        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("GameOver");

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LoadGameOverScene();
    }

}
