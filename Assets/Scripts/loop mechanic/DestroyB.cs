using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyB : MonoBehaviour
{

    public GameObject platformDestructB;
    public GameObject platformSpawnerRight;
    public int distanceBet;




    // Start is called before the first frame update
    void Start()
    {
        platformDestructB = GameObject.Find("PlatDestructB");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > platformDestructB.transform.position.x && transform.position.y < 18)
        {
            platformSpawnerRight.transform.position = new Vector3(platformSpawnerRight.transform.position.x - distanceBet, platformSpawnerRight.transform.position.y, 0);
            Destroy(gameObject);
        }
    }
}
