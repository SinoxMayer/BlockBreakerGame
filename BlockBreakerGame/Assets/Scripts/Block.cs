using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    //config params
    [SerializeField] AudioClip[] blockSounds;
    [SerializeField] GameObject blockSparklesVFX;


    //cached reference
    Level level;
    

    //AudioSource blockSound;
    //AudioSource blockSound2;
   

    private void Start()
    {
        CountBreakableBlocks();

    }

    private void CountBreakableBlocks()
    {
        //blockSound = GetComponent<AudioSource>();
        level = FindObjectOfType<Level>();
        if (tag == "Breakable")
        {
            level.CountBlocks();
        }
    }

    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //AudioClip clip = blockSounds[Random.Range(0, blockSounds.Length)];
       if (tag == "Breakable")
        {
            DestroyBlock();
        }
    
        
    }

    private void DestroyBlock()
    {
        BlockDestroySFX();
        Destroy(gameObject);
        level.BlockDestroyed();
        TrigerBlockSparksVFX();

    }

    private void BlockDestroySFX()
    {
        FindObjectOfType<GameSession>().AddToScore();

        AudioSource.PlayClipAtPoint(blockSounds[Random.Range(0, blockSounds.Length)], Camera.main.transform.position);
    }

    private void TrigerBlockSparksVFX()
    {
        GameObject sparkelts = Instantiate(blockSparklesVFX, transform.position, transform.rotation);
        Destroy(sparkelts, 1f);
        // burada yaptığım oluşan paçacık efeklerini 1 frame sonra yok et demek oldu . Bu sayede çok fazla spawn olan bir oyun olursa şişme yapmıyacak . 
    }
}
