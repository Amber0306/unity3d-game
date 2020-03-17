using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public  GameObject dialogLost;
    public  GameObject dialogWin;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public GameState() { }
    public  GameState(GameObject win,GameObject lose)
    {
        this.dialogLost = lose;
        this.dialogWin = win;
    }
   public void gameLose()
    {
        Debug.Log("the player loses the game");
        //bool isYes =UnityEditor.EditorUtility.DisplayDialog("YOU LOSE THE GAME! ",
        //    "DO YOU WANT TO RESTART THE GAME? ","YES, RESTART. ","NO, QUIT. ");
        //if(isYes)
        //{
        //    restartGame();
        //}
        //else
        //{
        //    Application.Quit();
        //}
        dialogLost.SetActive(true);
    }

    public void gameWin()
    {
        Debug.Log("the player wins the game");
        //bool isYes=UnityEditor.EditorUtility.DisplayDialog("YOU WIN THE GAME! ",
        //   "DO YOU WANT TO RESTART THE GAME? ", "YES, RESTART. ", "NO, QUIT. ");
        //if (isYes)
        //{
        //    restartGame();
        //}
        //else
        //{
        //    Application.Quit();
        //}
        dialogWin.SetActive(true);
    }

    //public static void restartGame()
    //{
    //    //修改人物位置
    //    Vector3 startPos;
    //    startPos.x = 6.5f;
    //    startPos.y = 22.92f;
    //    startPos.z = 9.26f;
    //    this.gameObject.GetComponent<Transform>().position = startPos;
    //    //血条加满
    //    blood = 1f;
    //    bloodBar.value = 1f;
    //}
}
