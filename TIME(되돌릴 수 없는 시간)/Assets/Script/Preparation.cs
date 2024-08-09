using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class  Preparation: MonoBehaviour
{
    public float sceneTime;
    public Text[] text;

    void Update()
    {
        sceneTime -= Time.deltaTime;

        if (sceneTime <= 0)
        {
            SceneManager.LoadScene("tutorial Scene");
            
        }

        if (sceneTime <= 5)
        {
            text[1].gameObject.SetActive(true);
            text[0].gameObject.SetActive(false);
        }
        
    }
}
