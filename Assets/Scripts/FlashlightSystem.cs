using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightSystem : MonoBehaviour
{
    // intensity, angle 비례상수와 flashlight 최소 angle 선언
    [SerializeField] float intensityPC = 0.1f;
    [SerializeField] float anglePC = 1f;
    [SerializeField] float minimumAngle = 40f;

    Light flashLight;

    // Start is called before the first frame update
    void Start()
    {
        flashLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseLightIntensity();
        DecreaseLightAngle();
    }

    // flashlight의 intensity를 비례상수 만큼 지속 감소
    private void DecreaseLightIntensity()
    {
        flashLight.intensity -= intensityPC * Time.deltaTime;
    }

    // flashlight의 angle을 비례상수 만큼 지속 감소
    private void DecreaseLightAngle()
    {
        if (flashLight.spotAngle > minimumAngle)
        {
            flashLight.spotAngle -= anglePC * Time.deltaTime;
        }
    }

    public void AddLightIntensity(float intensityAmount)
    {
        flashLight.intensity += intensityAmount;
    }

    public void RestoreLightAngle(float restoreAngle)
    {
        flashLight.spotAngle = restoreAngle;
    }
}
