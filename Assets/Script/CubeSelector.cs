using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSelector : MonoBehaviour
{
    [SerializeField]List<ColorChanger> colorChangers= new List<ColorChanger>();
    List<ColorChanger> colorBackUp = new List<ColorChanger>();

    private void Update()
    {
        if (colorChangers.Count >0)
        {
            foreach (var colorChanger in colorChangers)
            {
                colorChanger.SetColor(2f);
            }
        }
        if (colorBackUp.Count > 0)
        {
            foreach (var colorChanger in colorBackUp)
            {
                colorChanger.SetColor(-2f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out ColorChanger colorChanger))
        {
            colorChangers.Add(colorChanger);
            if (colorBackUp.Contains(colorChanger))
            {
                colorBackUp.Remove(colorChanger);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out ColorChanger colorChanger))
        {
            colorChangers.Remove(colorChanger);
            colorBackUp.Add(colorChanger);
        }
    }
}
