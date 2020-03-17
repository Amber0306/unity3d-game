using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapCancel : MonoBehaviour
{
    public GameObject camera;
    public Text text;
    Button btn;
    private bool IsCancel = true;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(delegate ()
        {
            onClik();
        });
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void onClik()
    {
        if (IsCancel)
        {
            camera.SetActive(false);
            text.text = "关";
            IsCancel = !IsCancel;
        }
        else
        {
            camera.SetActive(true);
            text.text = "开";
            IsCancel = !IsCancel;
        }
    }
}

