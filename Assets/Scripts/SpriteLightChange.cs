using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class SpriteLightChange : MonoBehaviour
{
    public Light2D light;

    private IEnumerator fadeInAndOutForever(Light2D lightToFade, bool fadeIn, float duration)
    {
        float minIntensity = 0.3f;
        float maxIntensity = 1.0f;

        // values depending if fade in or out
        float a, b;

        if (fadeIn)
        {
            a = minIntensity;
            b = maxIntensity;
        }
        else
        {
            a = maxIntensity;
            b = minIntensity;
        }
    }
}
