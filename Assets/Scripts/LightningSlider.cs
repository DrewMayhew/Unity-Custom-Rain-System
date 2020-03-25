using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningSlider : MonoBehaviour {

    ParticleSystem LightningNoiseTrail;


    [Range(0,3)]
    public float emission_rate = 0.1f;


    void Start()
    {
        LightningNoiseTrail = this.GetComponent<ParticleSystem>();
    }

    void Update ()
    {
        LightningNoiseTrail.emissionRate = emission_rate;
    }
}
