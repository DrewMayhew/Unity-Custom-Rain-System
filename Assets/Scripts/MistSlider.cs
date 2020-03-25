using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MistSlider : MonoBehaviour {

    ParticleSystem Mist;


    [Range(0, 250)]
    public float emission_rate = 0.5f;


    void Start()
    {
        Mist = this.GetComponent<ParticleSystem>();
    }

    void Update ()
    {
        Mist.emissionRate = emission_rate;
    }
}

