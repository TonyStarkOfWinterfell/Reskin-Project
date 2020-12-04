using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Health : MonoBehaviour
{

    private void Start()
    {
          
    }

    
    void Update()
    {
        if (gameObject.transform.position.y < -7)
        {
            Die();
        }
    }
       

    void Die()
    {
        StartCoroutine(Test());
    }

    IEnumerator Test()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("TitleScreen");
    }
}
