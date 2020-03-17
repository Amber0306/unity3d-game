using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    private Animator animator;
    private bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnMouseDown()
    {
        if (!isOpen)
        {
            Debug.Log("2222222222222222222222");
            animator.Play("doorOpen");
            isOpen = !isOpen;
        }
        else
        {
            animator.Play("doorClose");
            isOpen = !isOpen;
        }
    }
}
