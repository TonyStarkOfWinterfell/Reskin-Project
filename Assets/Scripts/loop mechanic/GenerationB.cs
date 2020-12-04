using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerationB : MonoBehaviour
{


    public GameObject thePlatformB;
    public Transform generationPointB;
    public int distanceBetweenB;


    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > generationPointB.position.x)
        {
            //thePlatformB = thePlatformB;
            transform.position = new Vector3(transform.position.x - distanceBetweenB, transform.position.y, transform.position.z);
            Instantiate(thePlatformB, transform.position, transform.rotation);
        }
    }
}
