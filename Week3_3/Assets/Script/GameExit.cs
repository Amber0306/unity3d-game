using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameExit : MonoBehaviour
{
    public GameObject dialog;
    Button btn;  
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
        dialog.SetActive(true);
    }
}
