using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyF : MonoBehaviour
{

    public GameObject platformDestruct;
    public GameObject platformSpawnerLeft;
    public int distanceBet;




    // Start is called before the first frame update
    void Start()
    {
        platformDestruct = GameObject.Find("PlatDestructF");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < platformDestruct.transform.position.x && transform.position.y < 18)
        {
            platformSpawnerLeft.transform.position = new Vector3(platformSpawnerLeft.transform.position.x + distanceBet, platformSpawnerLeft.transform.position.y, 0);
            Destroy(gameObject);
        }
    }
}
