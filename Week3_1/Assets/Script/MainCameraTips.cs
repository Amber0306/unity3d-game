using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCameraTips : MonoBehaviour
{
    public GameObject dialogWin;
    public GameObject dialogLost;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //捕获Android的系统返回键
        if (Application.platform == RuntimePlatform.Android || (Input.GetKeyDown(KeyCode.Escape)))
        {
            //弹窗，让玩家确认是否退出
            dialogWin.SetActive(true);
        }
    }
    public void ShowWin()
    {
        dialogWin.SetActive(true);
    }
    public void ShowLost()
    {
        dialogLost.SetActive(true);
    }
    public void OnClikWin()
    {
        SceneManager.LoadScene("SampleScene");
        //Debug.Log("s");
    }
    public void OnClikLost()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("School Corridor");
    }
    public void OnClikHome()
    {
        Debug.Log("home");
    }
}
