using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Name: Vasavi Jaladi
/// Project: Cat Assignment
/// Date: 05/06/2019
/// </summary>

public class Cat : MonoBehaviour
    
{
    public Material[] furColor;
    public Material[] eyeColor;
    public GameObject body;
    public GameObject rightEye;
    public GameObject leftEye;
   
    Renderer rend;

    // Use this for initialization
    void Start()
    {
        int colorIndex = (int)(Random.value * 3);

        RenderCube(body, colorIndex, furColor);

        colorIndex = (int)(Random.value * 3);
        RenderCube(rightEye, colorIndex, eyeColor);
        RenderCube(leftEye, colorIndex, eyeColor);
    }
    // Using Renderer Function for the Game Object
    private void RenderCube(GameObject obj, int colorIndex, Material[] color)
    {
        rend = obj.GetComponent<Renderer>();
        rend.enabled = true;

        rend.sharedMaterial = color[colorIndex];
    }
}
