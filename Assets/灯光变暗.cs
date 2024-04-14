using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 灯光变暗 : MonoBehaviour
{
    public Transform lightTransform;
    public float rotationSpeed = 5f;
    public GameObject hiddenPanel; // 引用隐藏面板

    private Vector3 initialRotation = new Vector3(0.974f, -446.916f, 95.446f);
    private Vector3 targetRotation = new Vector3(-38.76f, -445.788f, 94.704f);

    private bool isRotating = false;
    private Quaternion lastRotation;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !isRotating)
        {
            lastRotation = lightTransform.rotation;
            isRotating = true;
        }
        else if (Input.GetKeyDown(KeyCode.A) && !isRotating)
        {
            lastRotation = lightTransform.rotation;
            isRotating = true;
        }
        else if (Input.GetKeyDown(KeyCode.S) && !isRotating)
        {
            lastRotation = lightTransform.rotation;
            isRotating = true;
        }
        else if (Input.GetKeyDown(KeyCode.D) && !isRotating)
        {
            lastRotation = lightTransform.rotation;
            isRotating = true;
        }

        if (isRotating)
        {
            RotateLight();
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            isRotating = false;
        }
    }

    void RotateLight()
    {
        Vector3 rotationAmount = targetRotation - lightTransform.eulerAngles;
        Quaternion startRotation = lastRotation;
        Quaternion endRotation = Quaternion.Euler(lightTransform.eulerAngles + rotationAmount);
        float step = rotationSpeed * Time.deltaTime;
        lightTransform.rotation = Quaternion.RotateTowards(lightTransform.rotation, endRotation, step);

        // 检查是否旋转到达目标位置
        if (Quaternion.Angle(lightTransform.rotation, endRotation) < 0.1f)
        {
            ShowHiddenPanel();
        }
    }

    void ShowHiddenPanel()
    {
        hiddenPanel.SetActive(true);
    }

    void Start()
    {
        lightTransform.rotation = Quaternion.Euler(initialRotation);
        hiddenPanel.SetActive(false); // 开始时隐藏面板
    }
}