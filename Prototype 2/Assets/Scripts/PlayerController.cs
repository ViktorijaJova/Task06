using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float horizontalInput;
    public float speed = 10.0f;
    public GameObject bananas;


    //controlling players x range movment
    public float xRange = 10.0f;


     // one option for controlling range
/*    public float leftBoundry = -10.0f;
    public float rightBoundry = 10.0f;*/


    void Start()
    {
        
    }

    void Update()
    {
      
        //move left
        if (transform.position.x <= -xRange)
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
        //move right
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Instantiate(bananas, transform.position, bananas.transform.rotation);
        }
        //space to shoot bananas

    }
}
