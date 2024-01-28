using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustRenderTexture : MonoBehaviour
{
    public RenderTexture renderTexture;

    void Start()
    {
        // Set RenderTexture dimensions to match the screen's aspect ratio
        renderTexture.width = Screen.width;
        renderTexture.height = Screen.height;

        // Assuming mainCamera is your Camera
        Camera mainCamera = Camera.main;

        // Set camera's aspect ratio to match the screen
        mainCamera.aspect = (float)Screen.width / Screen.height;
    }
}











