using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WHTips2 : MonoBehaviour
{
    public GameObject dialogWin;
    public GameObject dialogLose;
    private CharacterController myCharacterController;
    // Start is called before the first frame update
    void Start()
    {

        myCharacterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        myCharacterController.Move(new Vector3(0, 0, 0));
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //得到接收碰撞名称
        GameObject hitObject = hit.collider.gameObject;
        if (hitObject.transform.name.Equals("Win"))
        {
            Time.timeScale = 0;
            dialogWin.SetActive(true);
        }
    }
 }
