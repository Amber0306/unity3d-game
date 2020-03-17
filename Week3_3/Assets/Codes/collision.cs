using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collision : MonoBehaviour
{

    public CharacterController myCharacterController;

    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        myCharacterController.Move(new Vector3(0, 0, 0));
        //Debug.Log("enter");
    }

    //角色控制器组件在与具有Collider组件对象之间的碰撞
    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //得到接收碰撞名称
        GameObject hitObject = hit.collider.gameObject;
        if (hitObject.transform.name.Equals("Cube"))
        {
            Debug.Log("collision");
        }
    }
}
