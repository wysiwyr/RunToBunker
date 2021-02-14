using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float intensityAmount = 1f;
    [SerializeField] float restoreAngle = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashlightSystem>().AddLightIntensity(intensityAmount);
            other.GetComponentInChildren<FlashlightSystem>().RestoreLightAngle(restoreAngle);
            Destroy(gameObject);
        }
    }
}
