using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;
using UnityEngine.UI;

public class GameSuspend : MonoBehaviour
{
    Button btn;
    Image image;
    public bool IsSuspend = true;

    // Start is called before the first frame update
    void Start()
    {
        btn = GetComponent<Button>();
        image = GetComponent<Image>();
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
        if (IsSuspend)
        {
            //Debug.Log("00");
            Time.timeScale = 0;
            //Sprite tmp = Resources.Load("suspend", typeof(Sprite)) as Sprite;
            //btn.interactable = false;
            //image.sprite = tmp;
            IsSuspend = !IsSuspend;
        }
        else
        {
            //Debug.Log("11");
            Time.timeScale = 1;
            IsSuspend = !IsSuspend;
        }
    }
}
