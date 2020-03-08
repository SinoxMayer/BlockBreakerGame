using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip[] blockSounds;
    Level level;

    //AudioSource blockSound;
    //AudioSource blockSound2;
   

    private void Start()
    {
        //blockSound = GetComponent<AudioSource>();
        level = FindObjectOfType<Level>();
        level.CountBreakableBlocks();

    }

    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //AudioClip clip = blockSounds[Random.Range(0, blockSounds.Length)];

        DestroyBlock();
    }

    private void DestroyBlock()
    {
        AudioSource.PlayClipAtPoint(blockSounds[Random.Range(0, blockSounds.Length)], Camera.main.transform.position);
        Destroy(gameObject);
        level.BlockDestroyed();
    }
}
