using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 25f;

    bool zoomedInToggle = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (zoomedInToggle)
            {
                fpsCamera.fieldOfView = zoomedInFOV;
            } else
            {
                fpsCamera.fieldOfView = zoomedOutFOV;
            }

            zoomedInToggle = !zoomedInToggle;
        }
    }
}
