using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDoor : UnityEngine.MonoBehaviour
{
    private Animator animator;
    private bool isopen = true;
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
        if (collision.gameObject.tag == "Player")
        {
            if (isopen)
            {
                animator.Play("bigdooropen");
                isopen = !isopen;
                Debug.Log("11");

            }
            else
            {
                animator.Play("bigdoorclose");
                isopen = !isopen;
            }
           
        }
    }
}
