using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCameraTips2 : MonoBehaviour
{
    public GameObject dialogSettings;
    //public GameObject dialogLose;
    //public GameObject dialogWin;
    // Start is called before the first frame update
    void Start()
    {
        dialogSettings.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onClikLose()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("AtHome");
    }
    public void onClikHome()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("home");
    }
}
