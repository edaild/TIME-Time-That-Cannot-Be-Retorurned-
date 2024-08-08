using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;


public class GameManiser : MonoBehaviour
{

    public RectTransform[] spring = new RectTransform[4];       // Å« ÅÂ¿±
    public RectTransform[] s_spring = new RectTransform[8];     // ÀÛÀº ÅÂ¿±
    public float rotateSpeed;


    private void Update()
    {
        if (spring != null)
        {
            spring[0].Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime);
            spring[1].Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime);
            spring[2].Rotate(new Vector3(0, 0, -rotateSpeed) * Time.deltaTime);
            spring[3].Rotate(new Vector3(0, 0, -rotateSpeed) * Time.deltaTime);
        }

        if (s_spring != null)
        {
            s_spring[0].Rotate(new Vector3(0, 0, -rotateSpeed) * Time.deltaTime);
            s_spring[1].Rotate(new Vector3(0, 0, -rotateSpeed) * Time.deltaTime);
            s_spring[2].Rotate(new Vector3(0, 0, -rotateSpeed) * Time.deltaTime);
            s_spring[3].Rotate(new Vector3(0, 0, -rotateSpeed) * Time.deltaTime);

            s_spring[4].Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime);
            s_spring[5].Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime);
            s_spring[6].Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime);
            s_spring[7].Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime);

        }
    }

    public void OnButtonclick_Gamestart()
    {
        SceneManager.LoadScene("preparationScene");
    }

}
