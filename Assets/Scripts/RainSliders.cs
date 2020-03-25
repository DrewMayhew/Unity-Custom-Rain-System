using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainSliders : MonoBehaviour
{
    ParticleSystem rain;

    [Range(0, 250)]
    public float emission_rate = 0.5f;

    void Start()
    {
        rain = this.GetComponent<ParticleSystem>();
    }

    void Update()
    {
       rain.emissionRate = emission_rate;
    }
}
