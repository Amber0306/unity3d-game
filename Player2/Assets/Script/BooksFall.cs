using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BooksFall : UnityEngine.MonoBehaviour
{
    private bool IsPlay=true;
    private Animator animator;
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
            int rand = Random.Range(1, 100);
            
            if (rand ==1)
            {
                if (IsPlay)
                {
                    
                    animator.Play("booksfall");
                    IsPlay = false;
                }
            }
        }
    }
}
