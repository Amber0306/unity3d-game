using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
/// <summary>
/// 加载场景--脚本挂载前场景
/// </summary>

public class Slider1 : MonoBehaviour
{

    private Slider slider;//滑动条
    int currentProgess;//当前进度
    int targetProjess;//目标进度
    public Text text;

    // Start is called before the first frame update
    private void Start()
    {
        currentProgess = 0;
        targetProjess = 0;
        slider = GameObject.Find("Slider").GetComponent<Slider>();

        StartCoroutine(LoadingScene());//开启协议

    }

    // Update is called once per frame
    private IEnumerator LoadingScene()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync("home");
        asyncOperation.allowSceneActivation = false;
        while (asyncOperation.progress < 0.9f)
        {
            targetProjess = (int)(asyncOperation.progress * 100
             );
            yield return LoadProgress();
        }
        targetProjess = 100;
        yield return LoadProgress();
        asyncOperation.allowSceneActivation = true;//加载完毕，这里激活场景-跳转场景成功
    }
    ///<summary>
    ///由于需要调用两次，在这里简单封装
    ///</summary>
    private IEnumerator<WaitForEndOfFrame> LoadProgress()
    {
        while (currentProgess < targetProjess)//当前进度小于目标进度时
        {
            currentProgess += 2;//当前进度不断增加
            text.text = currentProgess.ToString() + "%";
            slider.value = (float)currentProgess / 100;


            yield return new WaitForEndOfFrame();
        }
    }
}
