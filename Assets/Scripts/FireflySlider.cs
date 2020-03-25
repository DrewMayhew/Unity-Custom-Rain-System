using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireflySlider : MonoBehaviour {

    ParticleSystem Fireflies;


    [Range(0, 250)]
    public float emission_rate = 0.5f;


    void Start()
    {
        Fireflies = this.GetComponent<ParticleSystem>();
    }

    void Update ()
    {
        Fireflies.emissionRate = emission_rate;
    }
}
