using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSlider : MonoBehaviour {

    ParticleSystem Cloud;


    [Range(0, 250)]
    public float emission_rate = 0.5f;


    void Start()
    {
        Cloud = this.GetComponent<ParticleSystem>();
    }

    void Update ()
    {
        Cloud.emissionRate = emission_rate;
    }
}
