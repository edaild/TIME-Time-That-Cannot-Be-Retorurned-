using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class tutorial : MonoBehaviour
{
    public GameObject textUI;
    public Text npcName;
    public Text textObject;
    public GameObject npcImags;
    public int npc_clickCount = 0;
    public int text_Count = 0;
    public bool mouseClick;
    public float cs_time;

    private void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.transform.gameObject);

            if (hit.transform.gameObject.tag == "IA")
            {
                if (Input.GetMouseButtonDown(0))
                {
                    textUI.SetActive(true);
                    npcName.text = "이아";

                    if (npc_clickCount == 0)
                    {
                        print(npc_clickCount);
                        textObject.text = "안녕하세요 저는 페이리 타운에\n 시간의 여신 이아 입니다.";
                        npc_clickCount += 1;
                        text_Count = 1;

                    }
                }
                mouseClick = false;
            }
            else if (text_Count == 1)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    textObject.text = "이곳은 요정의 세계 페어리 타운 입니다.";
                    text_Count = 2;
                }
            }
            else if (text_Count == 2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    textObject.text = "페어리 타운은 요정들이 시간 마법에 \n 흐름에 따라 사는 곳 입니다.";
                    text_Count = 3;
                }
            }
            else if (text_Count == 3)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    textObject.text = "페어리 마법을 사용하기 위해서는\n 마법시험에 합격해야 합니다.";
                    text_Count = 4;
                }
            }
            else if (text_Count == 4)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    textObject.text = "축하합니다. 모든 시험에 합격했습니다.\n 이제 페어리 타운 에서 즐거운  모험되세요.";
                    text_Count = 5;
                }
            }
            else if (text_Count == 5)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    textUI.gameObject.SetActive(false);

                    SceneManager.LoadScene("preparationScene 02");

                }
                
            }


        }
    }
}
