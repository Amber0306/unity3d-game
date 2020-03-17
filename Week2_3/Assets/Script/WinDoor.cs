using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinDoor : MonoBehaviour
{
    public GameObject dialog;

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
            dialog.SetActive(true);
        }
    }
    public void Show()
    {
        dialog.SetActive(true);
    }
    public void OnClik()
    {
        SceneManager.LoadScene("SampleScene");
        Debug.Log("s");
    }
}
