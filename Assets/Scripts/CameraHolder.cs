using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{

    void Update()
    {
        // �������� �������� ������ �����
        Camera cam = Camera.main;

        // ��������� ������ �� ������ �� ������� �������
        Vector3 cameraToObject = transform.position - cam.transform.position;

        // ���������� ���������� �� ������ �� ������� �� ��� Y
        float distance = -Vector3.Project(cameraToObject, cam.transform.forward).y;

        // ��������� ���������� ������ "�����" �������� ��������� ������
        Vector3 leftBot = cam.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 rightTop = cam.ViewportToWorldPoint(new Vector3(1, 1, distance));

        // ���������� ������� � ��������� XZ
        float x_left = leftBot.x;
        float x_right = rightTop.x;
        float z_top = rightTop.z;
        float z_bot = leftBot.z;

        // ������������ ������ � ��������� XZ
        Vector3 clampedPos = transform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, x_left, x_right);
        clampedPos.z = Mathf.Clamp(clampedPos.z, z_bot, z_top);
        transform.position = clampedPos;
    }
}


