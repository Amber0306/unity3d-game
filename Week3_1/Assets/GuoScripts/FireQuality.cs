using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//运动到不同的楼层，火焰跟随显示
public class FireQuality : UnityEngine.MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private int level;
    public GameObject Fire1;
    public GameObject Fire2;
    public GameObject Fire3;
    public GameObject Fire4;
    void Start()
    {
        DisappearFire();
    }

    // Update is called once per frame
    void Update()
    {
        float height = player.GetComponent<Transform>().position.y;
        level = LevelCheck(height);
        LevelShow(level);
        ;
    }

    //检测player位置
    //判断在几楼
    public int LevelCheck(float height)
    {
        if (height < 6.83f)
        {
            level = 1;
        }
        else if (height > 6.83f && height < 13.22f)
        {
            level = 2;
        }
        else if (height > 13.22f && height < 20)
        {
            level = 3;
        }
        else
        {
            level = 4;
        }
        Debug.Log("the player is in the level " + level);
        return level;
    }

    //设置该楼层火焰显示，其他楼层不显示
    public void LevelShow(int level)
    {
        //这里调用disappearFire时出现问题
        switch (level)
        {
            case 1:
                Debug.Log("the fire in level 1 is active");
                Fire1.SetActive(true);
                Fire2.SetActive(false);
                Fire3.SetActive(false);
                Fire4.SetActive(false);
                break;
            case 2:
                Debug.Log("the fire in level 2 is active");
                Fire2.SetActive(true);
                Fire1.SetActive(false);
                Fire3.SetActive(false);
                Fire4.SetActive(false);
                break;
            case 3:
                Debug.Log("the fire in level 3 is active");
                Fire3.SetActive(true);
                Fire1.SetActive(false);
                Fire2.SetActive(false);
                Fire4.SetActive(false);
                break;
            case 4:
                Debug.Log("the fire in level 4 is active");
                Fire4.SetActive(true);
                Fire1.SetActive(false);
                Fire2.SetActive(false);
                Fire3.SetActive(false);
                break;
        }
    }

    //使火全不显示
    private void DisappearFire()
    {
        Debug.Log("the fire is not active");
        Fire1.SetActive(false);
        Fire2.SetActive(false);
        Fire3.SetActive(false);
        Fire4.SetActive(false);
    }
}

