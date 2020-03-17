using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    private GameObject dialogSetting;
    // Start is called before the first frame update
    void Start()
    {
        dialogSetting = GameObject.Find("Settings");
        dialogSetting.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
