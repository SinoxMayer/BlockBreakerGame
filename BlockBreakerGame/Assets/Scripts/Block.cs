using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip[] blockSounds;


    //AudioSource blockSound;
    //AudioSource blockSound2;
   

    void Start()
    {
        //blockSound = GetComponent<AudioSource>();
     
    }

    private void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //AudioClip clip = blockSounds[Random.Range(0, blockSounds.Length)];
        
        AudioSource.PlayClipAtPoint(blockSounds[Random.Range(0, blockSounds.Length)], Camera.main.transform.position);
        Destroy(gameObject);

    }


}
