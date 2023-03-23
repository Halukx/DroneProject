using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    Material material;
    public float colorValue;
    private void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    public void SetColor(float percentes)
    {
        colorValue += Time.deltaTime * percentes;
        colorValue = Mathf.Clamp01(colorValue);
        material.color = Color.Lerp(Color.white,Color.red, colorValue);
    }
}
