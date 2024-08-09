using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float MoveSpeed = 3f;
    public float ZoomSpeed;         // �� ���ǵ�.
    public float Distance;          // ī�޶���� �Ÿ�.
    public float rotateSpeed = 5.0f;
    public float limitAngle = 70.0f;    //����Ʈ �ޱ�

    private bool isRotate;
    private float mouseX;
    private float mouseY;

    private Vector3 AxisVec;        // ���� ����.
    private Transform MainCamera;   // ī�޶� ������Ʈ.


    void Start()
    {
        MainCamera = Camera.main.transform;
    }

    void Update()
    {
        transform.position = target.position + offset;

        Zoom();
        CameraRotate();
    }

    void Zoom()
    {
        Distance += Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed * -1;

        Distance = Mathf.Clamp(Distance, 1f, 10f);              //Mathf ������ �Լ�

        AxisVec = transform.forward * -1;

        AxisVec *= Distance;

        MainCamera.position = transform.position + AxisVec;
    }

    void CameraRotate()
    {

        if (Input.GetMouseButtonDown(1))
        {
            isRotate = true;
        }
        if (Input.GetMouseButtonUp(1))
        {
            isRotate = false;
        }

        if (isRotate)
        {
            Rotation();
        }
    }

    public void Rotation()
    {
        mouseX += Input.GetAxis("Mouse X") * rotateSpeed; // AxisX = Mouse Y

        mouseY = Mathf.Clamp(mouseY + Input.GetAxis("Mouse Y") * rotateSpeed, -limitAngle, limitAngle);

        transform.rotation = Quaternion.Euler(transform.rotation.x - mouseY, transform.rotation.y + mouseX, 0.0f);
    }
}
