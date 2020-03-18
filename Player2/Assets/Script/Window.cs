using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : UnityEngine.MonoBehaviour
{
    private Animator animator;
    private bool isopen = true;
    private bool isTip = true;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (isopen)
            {
                animator.Play("windowopen");
                isopen = !isopen;

            }
            else
            {
                animator.Play("windowclose");
                isopen = !isopen;
            }
            if (isTip)
            {
                GameObject.Find("Tip").GetComponent<ShowTip>().show("火势再大，跳楼也是一种很不明智的行为，但是必要的时候可以滑绳自救");
                isTip = false;
            }
        }
    }
}
