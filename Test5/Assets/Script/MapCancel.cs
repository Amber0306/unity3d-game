using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapCancel : MonoBehaviour
{
    public GameObject camera;
    public Text text;
    Button btn;
    private int isMap;
    // Start is called before the first frame update
    void Start()
    {
        Map();

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
        if (isMap == 1)
        {
            camera.SetActive(false);
            text.text = "关";
            isMap = -1;
        }
        else
        {
            camera.SetActive(true);
            text.text = "开";
            isMap = 1;
        }
        PlayerPrefs.SetInt("isMap", isMap);
    }

    private void Map()
    {
        if (!PlayerPrefs.HasKey("isMap"))
        {
            PlayerPrefs.SetInt("isMap", 1);
        }
        isMap = PlayerPrefs.GetInt("isMap");
        if (isMap == 1)
        {
            camera.SetActive(true);
            text.text = "开";
        }
        else
        {
            camera.SetActive(false);
            text.text = "关";
        }
    }
}

