using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostMake : MonoBehaviour
{
    public VolumeProfile VolumeProfile;
    public float bloomVal;
    Bloom bm;

    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        VolumeProfile.TryGet(out bm);
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; 
        bm.intensity.value = bloomVal;
    }
}
