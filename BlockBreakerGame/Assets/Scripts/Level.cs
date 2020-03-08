using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{

    [SerializeField]int breakableBloocks;// Debug için 

    SceneLoader sceneloader;
    private void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void CountBreakableBlocks()
    {
        breakableBloocks++;
    }
public void BlockDestroyed()

    {

        breakableBloocks--;
        if(breakableBloocks <= 0)
        {

            sceneloader.LoadNextScene();


        }

    }
}
