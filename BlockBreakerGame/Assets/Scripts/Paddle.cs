using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Paddle : MonoBehaviour
{

    [SerializeField] float ScreenWidthUnits = 16f;
    [SerializeField] float xMin = 1.0f, xMax = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.mousePosition.x/Screen.width*ScreenWidthUnits);
        float xPos = Mathf.Clamp( Input.mousePosition.x / Screen.width * ScreenWidthUnits ,xMin,xMax  );
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y);
        paddlePos.x = xPos;
        transform.position = paddlePos;
    }
}
