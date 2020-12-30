using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounce : MonoBehaviour
{
    //how far the bananas go
    private float topbound = 50;
    //how far the animals go
    private float lowerbound = -10;
  
   
    void Start()
    {
        
    }

    void Update()
    {
        // when the bananas go out of the view destroy them
        if (transform.position.z == topbound)
        {
            Destroy(gameObject);
        }
        //same with animals
        else if (transform.position.z < lowerbound)
        {
           
            Destroy(gameObject);
        }
    }
}
