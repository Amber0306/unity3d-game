using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : UnityEngine.MonoBehaviour
{
    private Animator animator;
    private int isopen = 1;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();   
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        if (isopen == 1)
        {
            //Debug.Log("11111");
            animator.Play("dooropen");
            isopen = 2;

        }
        else if (isopen == 2)
        {
            //Debug.Log("22222");
            animator.Play("doorclose");
            isopen = 1;
        }
    }       
}

