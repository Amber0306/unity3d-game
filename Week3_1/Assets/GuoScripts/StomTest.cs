using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StomTest : MonoBehaviour
{
    private Random_fire rf;
    CharacterController myCharacterController;
    // Start is called before the first frame update
    void Start()
    {
        myCharacterController = this.gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        myCharacterController.Move(new Vector3(0, 0, 0));
    }

    public void OnControllerColliderHit(ControllerColliderHit hit)
    {
        GameObject hitObject = hit.collider.gameObject;
        if(hitObject.transform.name.Equals("floorFull"))
        {
            //弹出匍匐前进提示框

        }
        else if (hitObject.transform.name.Equals("floorTest"))
        {
            Debug.Log("the player need to crawl");
            //判断用户是否匍匐前进
            if(ani.bodyState)//如果站立
            {
                //游戏失败
                GameState.gameLose();
            }
        }
    }
}
