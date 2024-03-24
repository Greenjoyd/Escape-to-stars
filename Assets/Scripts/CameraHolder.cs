using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{

    void Update()
    {
        // Получаем основную камеру сцены
        Camera cam = Camera.main;

        // Вычисляем вектор от камеры до позиции объекта
        Vector3 cameraToObject = transform.position - cam.transform.position;

        // Определяем расстояние от камеры до объекта по оси Y
        float distance = -Vector3.Project(cameraToObject, cam.transform.forward).y;

        // Вычисляем координаты вершин "среза" пирамиды видимости камеры
        Vector3 leftBot = cam.ViewportToWorldPoint(new Vector3(0, 0, distance));
        Vector3 rightTop = cam.ViewportToWorldPoint(new Vector3(1, 1, distance));

        // Определяем границы в плоскости XZ
        float x_left = leftBot.x;
        float x_right = rightTop.x;
        float z_top = rightTop.z;
        float z_bot = leftBot.z;

        // Ограничиваем объект в плоскости XZ
        Vector3 clampedPos = transform.position;
        clampedPos.x = Mathf.Clamp(clampedPos.x, x_left, x_right);
        clampedPos.z = Mathf.Clamp(clampedPos.z, z_bot, z_top);
        transform.position = clampedPos;
    }
}


