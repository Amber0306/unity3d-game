using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class GameSuspend : MonoBehaviour
{
    Button btn;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        image = GetComponent<Image>();
        btn.onClick.AddListener(delegate ()
        {
            onClikSuspend();
        });
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void onClikSuspend()
    {
        Time.timeScale = 0;
    }
    public void onClikStart()
    {
        Time.timeScale = 1;
    }
}
