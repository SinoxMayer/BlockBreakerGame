﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour

{


    [Range(0.5f,5f)] [SerializeField] float gameSpeed = 1f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // update için yazıyorum çünkü canlı statüs cekicem frame frame bilicez

        Time.timeScale = gameSpeed;


    }
}
