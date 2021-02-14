using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas playerHitEffectCanvas;
    [SerializeField] float effectHoldingTime = 0.3f;

    // Start is called before the first frame update
    void Start()
    {
        playerHitEffectCanvas.enabled = false;
    }

    public void ShowHitEffect()
    {
        StartCoroutine(ShowSplatter());
    }

    IEnumerator ShowSplatter()
    {
        playerHitEffectCanvas.enabled = true;
        yield return new WaitForSeconds(effectHoldingTime);
        playerHitEffectCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
