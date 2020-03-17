using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairFall : MonoBehaviour
{
    private bool IsPlay = true;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInParent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int rand = Random.Range(1, 300);          
            if (rand == 1)
            {
                if (IsPlay)
                {
                    
                    animator.Play("chairfall");
                    IsPlay = false;
                }
            }
            else if (rand == 2)
            {
                if (IsPlay)
                {
                    animator.Play("chairfall2");
                    IsPlay = false;
                }
            }
        }
    }
}
