using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StomTest : MonoBehaviour
{
    public CharacterController myCharacterController;
    //private GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject win = GameObject.Find("DialogWin");
        //GameObject lose = GameObject.Find("DialogLose");
        //gameState = new GameState(win,lose);
        myCharacterController = this.gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v3 = myCharacterController.GetComponent<Transform>().position;
        if (v3.y<5.94)
        {
            if ((v3.x < 34.95 && v3.x > -54.8) && (v3.z > 11.86 && v3.z < 18.39) && (ani.bodyState != false))
            {
                GameObject.Find("unitychan (1)").GetComponent<Role_Fire>().bloodBar.value = 0.01F;
                GameObject.Find("unitychan (1)").GetComponent<Role_Fire>().colorCheck();
                GameObject.Find("Main Camera").GetComponent<GameState>().gameLose();
            }
        }
        
    }


}
