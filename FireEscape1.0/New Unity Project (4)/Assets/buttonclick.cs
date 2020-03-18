using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonclick : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnLoadScene(int SceneNum)
    {
        SceneManager.LoadSceneAsync( SceneNum       );
    }
}
