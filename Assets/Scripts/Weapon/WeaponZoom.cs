using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] RigidbodyFirstPersonController fpsController;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 25f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 1f;

    bool zoomedInToggle = false;

    private void OnDisable()
    {
        ZoomInToggle(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle)
            {
                ZoomInToggle(true);
            }
            else
            {
                ZoomInToggle(false);
            }

            zoomedInToggle = !zoomedInToggle;
        }
    }

    private void ZoomInToggle(bool toggle)
    {
        if (toggle)
        {
            fpsCamera.fieldOfView = zoomedInFOV;
            fpsController.mouseLook.XSensitivity = zoomInSensitivity;
            fpsController.mouseLook.YSensitivity = zoomInSensitivity;
        }
        else
        {
            fpsCamera.fieldOfView = zoomedOutFOV;
            fpsController.mouseLook.XSensitivity = zoomOutSensitivity;
            fpsController.mouseLook.YSensitivity = zoomOutSensitivity;
        }
    }
}
