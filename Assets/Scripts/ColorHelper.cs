using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorHelper : MonoBehaviour
{
    

    public static void ChangeColor(Object obj, Color col)
    {
        obj.GetComponent<Renderer>().material.color = col;
    }

    public static void ChangeColor(Object objecte)
    {
        objecte.GetComponent<Renderer>().material.color = Random.ColorHSV();
    }

    public static void SetDefaultColor(Object objeto)
    {
        objeto.GetComponent<Renderer>().material.color = colorDefault;
    }    
}
