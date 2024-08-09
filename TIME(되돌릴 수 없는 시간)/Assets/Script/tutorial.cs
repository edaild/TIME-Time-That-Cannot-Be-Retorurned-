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
                    npcName.text = "�̾�";

                    if (npc_clickCount == 0)
                    {
                        print(npc_clickCount);
                        textObject.text = "�ȳ��ϼ��� ���� ���̸� Ÿ�\n �ð��� ���� �̾� �Դϴ�.";
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
                    textObject.text = "�̰��� ������ ���� �� Ÿ�� �Դϴ�.";
                    text_Count = 2;
                }
            }
            else if (text_Count == 2)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    textObject.text = "�� Ÿ���� �������� �ð� ������ \n �帧�� ���� ��� �� �Դϴ�.";
                    text_Count = 3;
                }
            }
            else if (text_Count == 3)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    textObject.text = "�� ������ ����ϱ� ���ؼ���\n �������迡 �հ��ؾ� �մϴ�.";
                    text_Count = 4;
                }
            }
            else if (text_Count == 4)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    textObject.text = "�����մϴ�. ��� ���迡 �հ��߽��ϴ�.\n ���� �� Ÿ�� ���� ��ſ�  ����Ǽ���.";
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
