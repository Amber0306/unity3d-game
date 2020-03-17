using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//测试角色碰撞火焰行为
public class Role_Fire : MonoBehaviour
{ 
    public static float blood=1f;
    public static float deSpeed=0.1f;
    public Slider bloodBar;
    private float decrease = 10f;
    //public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        bloodBar.value = 1f;
        //moveSpeed = 1.0f;
        colorCheck();
    }

    // Update is called once per frame
    void Update()
    {
        //正常血量逐渐减少，每10秒减少一次
        decrease -= Time.deltaTime;
        if (decrease < 0)
        {
            //合并
            decBlood(0.05f);
            decrease += 10;//间隔
        }
        if (transform.position.z > 20)
        {
            decBlood(-0.1f);
            decrease += 10;//间隔
        }
        //逃出教学楼，则成功
        //Vector3 pos = this.gameObject.GetComponent<Transform>().position;
        //if ((pos.x>37&&pos.x<39)&&(pos.y>1&pos.y<1.25)&&(pos.z>20&&pos.z<21))
        //{
        //    gameWin();
        //}
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Debug.Log("role go to the foward");
        //    transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
        //}
        //if (Input.GetKey(KeyCode.A))
        //{
        //    Debug.Log("role go to left");
        //    transform.Translate(Vector3.left * Time.deltaTime * moveSpeed);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    Debug.Log("role go to the back");
        //    transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    Debug.Log("role go to the right");
        //    transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        //}
    }

    //碰撞开始  
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name+" collides the player");
        //与火碰撞
        if(collision.gameObject.name=="ColliderTest")
        {
            //如果与火焰中碰撞检测器碰到
            Debug.Log("the player contacts the fire");
            //血量减少
            blood -= deSpeed;
            Debug.Log("the blood now is " + blood);
            //控制显示
            //标签和血条
            if (bloodBar.value < 0.1)
            {
                //处理跳转
                GameState.gameLose();
            }
            else
            {
                bloodBar.value -= 0.1f;
                colorCheck();
            }          
        }
        //胜利的曙光
        if(collision.gameObject.name=="GameSuccess")
        {
            GameState.gameWin();
        }
    }

    //碰撞中  
    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "GameSuccess")
        {
            Debug.Log("碰撞中,碰撞名称：" + collision.gameObject.name);
            GameState.gameWin();
        }
    }

    ////碰撞结束  
    //void OnCollisionExit(Collision collision)
    //{
    //    if (collision.gameObject.name=="Sphere")
    //    {
    //        Debug.Log("碰撞结束,碰撞名称："+collision.gameObject.name);
    //    }
    //}  

    public float decBlood(float x)
    {
        blood -= x;
        if(blood<0)
        {
            GameState.gameLose();
        }
        else
        {
            bloodBar.value -= x;
            Debug.Log("the blood decrease normally ");
            colorCheck();
        }
        return blood;
        //return 1;
    }

    public void colorCheck()
    {
        GameObject fore = GameObject.FindGameObjectWithTag("Foreground");
        fore.GetComponent<UISprite>().color = Color.green;
        //开始是绿色
        if (bloodBar.value<0.3)
        {
            if(bloodBar.value<0.12)
            {
                //变为黄色
                fore.GetComponent<UISprite>().color = Color.red;
            }
            else
            {
                //变为红色
                fore.GetComponent<UISprite>().color = Color.yellow;
            }
        }
    }

    //public void gameLose()
    //{
    //    Debug.Log("the player loses the game");
    //    //bool isYes =UnityEditor.EditorUtility.DisplayDialog("YOU LOSE THE GAME! ",
    //    //    "DO YOU WANT TO RESTART THE GAME? ","YES, RESTART. ","NO, QUIT. ");
    //    //if(isYes)
    //    //{
    //    //    restartGame();
    //    //}
    //    //else
    //    //{
    //    //    Application.Quit();
    //    //}
    //    GameState.dialogLost.SetActive(true);
    //}

    //public void gameWin()
    //{
    //    Debug.Log("the player wins the game");
    //    //bool isYes=UnityEditor.EditorUtility.DisplayDialog("YOU WIN THE GAME! ",
    //    //   "DO YOU WANT TO RESTART THE GAME? ", "YES, RESTART. ", "NO, QUIT. ");
    //    //if (isYes)
    //    //{
    //    //    restartGame();
    //    //}
    //    //else
    //    //{
    //    //    Application.Quit();
    //    //}
    //    GameState.dialogWin.SetActive(true);
    //}

    public void restartGame()
    {
        //修改人物位置
        Vector3 startPos;
        startPos.x =6.5f;
        startPos.y =22.92f;
        startPos.z =9.26f;
        this.gameObject.GetComponent<Transform>().position = startPos;
        //血条加满
        blood = 1f;
        bloodBar.value = 1f;
    }
    
}
