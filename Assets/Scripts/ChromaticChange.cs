using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class ChromaticChange : MonoBehaviour
{
    public ChromaticAberration chromatic;
   // public PostProcessProfile profile;
    public PostProcessVolume volume;

    private float minIntensity = 0.1f;
    private float maxIntensity = 0.6f;
    private void Start()
    {
        //profile = GetComponent<PostProcessProfile>();
        //chromatic = profile.GetSetting<ChromaticAberration>();
        volume = GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out chromatic);
    }

    private void Update()
    {
        
    }

    private void ChangeChromatic()
    {
        
    }

    private IEnumerator ChangeValue(float a, float b)
    {

        yield return new WaitForSeconds(1f);
    }
}
