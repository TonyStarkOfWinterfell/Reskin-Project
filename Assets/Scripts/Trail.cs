using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trail : MonoBehaviour
{
      
    public Animator animator;


    public void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Counter(int pick)
    {        
        animator.SetInteger("PickA", pick);
    }





    //switch statement for animation here
}
