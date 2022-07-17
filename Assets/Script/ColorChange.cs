using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChange : MonoBehaviour
{
    public MeshRenderer Matchange;

    public Slider changecolormat;

    // Update is called once per frame
    public void changecolor()
    {
        Color color = Matchange.material.color;
        color.r = changecolormat.value;
        Matchange.material.color = color;
        Matchange.material.SetColor("_EmissionColor", color);
    }
}
