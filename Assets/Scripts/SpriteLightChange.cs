using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SpriteLightChange : MonoBehaviour
{
    private Light2D light;
    private float minIntensity = 0.3f;
    private float maxIntensity = 1.5f;
    private float pulseSpeed = 1f;
    private float currentIntensity;
    private float targetIntensity = 1.5f;
    
    private Transform lightTransform;
    private float zRotation;

    private void Start()
    {
        light = GetComponent<Light2D>();
        lightTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        ChangeIntensity();
        RotateLight();
    }

    void ChangeIntensity()
    {
        currentIntensity = Mathf.MoveTowards(light.intensity,targetIntensity, Time.deltaTime*pulseSpeed);
        if(currentIntensity >= maxIntensity)
        {
            currentIntensity = maxIntensity;
            targetIntensity = minIntensity;
        }
        else if(currentIntensity <= minIntensity)
        {
            currentIntensity = minIntensity;
            targetIntensity = maxIntensity;
        }
        light.intensity = currentIntensity;
    }

    void RotateLight()
    {
        transform.Rotate(0, 0, 10f*Time.deltaTime);
    }
}
