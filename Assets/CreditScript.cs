using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditScript : MonoBehaviour {

    public void LoadScene(string sceneName)
    { 
        SceneManager.LoadScene(sceneName);
    }
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene("MM");
        }
    }
}
