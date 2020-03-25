using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brightness : MonoBehaviour
{
    [Range(0,10)]
    public float rgbValue = 0.5f;
    public Color light_colour;

    private void Update()
    {
        GetComponent<Light>().intensity = rgbValue;
        GetComponent<Light>().color = light_colour;
    }
}