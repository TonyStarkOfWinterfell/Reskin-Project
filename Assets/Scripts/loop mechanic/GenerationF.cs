using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationF : MonoBehaviour
{


    public GameObject thePlatform;
    public Transform generationPoint;
    public float distanceBetween;    
    


    // Update is called once per frame
    void Update()
    {       
        if (transform.position.x < generationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(thePlatform, transform.position, transform.rotation);           
        }
    }
}
