//using System.Diagnostics;
//using UnityEngine;
//using static System.Net.Mime.MediaTypeNames;
//using System.IO;

//public class DrawingSave : MonoBehaviour
//{
//    public DrawWithMouse drawWithMouse;
//    public RenderTexture renderTexture;
//    public Camera renderCamera;

//    public void SaveDrawing()
//    {
//        // Convert the render texture to a Texture2D object
//        Texture2D texture = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
//        RenderTexture.active = renderTexture;
//        texture.ReadPixels(new Rect(0, 0, renderTexture.width, renderTexture.height), 0, 0);
//        texture.Apply();

//        // Encode the Texture2D object to a PNG file
//        byte[] bytes = texture.EncodeToPNG();

//        // Save the PNG file to the application data path
//        string path = UnityEngine.Application.dataPath + "/drawing.png";
//        File.WriteAllBytes(path, bytes);
//        UnityEngine.Debug.Log("Saved to " + path);
//    }
//}

using System.Diagnostics;
using UnityEngine;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

public class DrawingSave : MonoBehaviour
{
    public DrawWithMouse drawWithMouse;
    public RenderTexture renderTexture;
    public Camera renderCamera;

    public void SaveDrawing()
    {
        // Convert the render texture to a Texture2D object
        Texture2D texture = new Texture2D(renderTexture.width-535, renderTexture.height, TextureFormat.RGB24, false);
        RenderTexture.active = renderTexture;
        texture.ReadPixels(new Rect(535, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture.Apply();

        // Encode the Texture2D object to a PNG file
        byte[] bytes = texture.EncodeToPNG();

        // Save the PNG file to the application data path
        string path = UnityEngine.Application.dataPath + "/drawing.png";
        File.WriteAllBytes(path, bytes);
        UnityEngine.Debug.Log("Saved to " + path);
    }
}


//using UnityEngine;
//using System.IO;
//using static System.Net.Mime.MediaTypeNames;
//using System.Diagnostics;

//public class DrawingSave : MonoBehaviour
//{
//    public DrawWithMouse drawWithMouse;
//    public RenderTexture renderTexture;
//    public Camera renderCamera;
//    public GameObject borderObject;

//    public void SaveDrawing()
//    {
//        // Convert the render texture to a Texture2D object
//        Texture2D texture = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.RGB24, false);
//        RenderTexture.active = renderTexture;

//        // Determine the screen space coordinates of the right edge of the border object
//        Vector3 borderObjectScreenPos = Camera.main.WorldToScreenPoint(borderObject.transform.position);
//        float rightEdgeX = borderObjectScreenPos.x + borderObject.GetComponent<SpriteRenderer>().bounds.extents.x;

//        // Define the capture rectangle (to the right of the border object)
//        Rect captureRect = new Rect(rightEdgeX, 0, renderTexture.width - rightEdgeX, renderTexture.height);

//        // Read only the specified region of the RenderTexture
//        texture.ReadPixels(captureRect, 0, 0);
//        texture.Apply();

//        // Encode the Texture2D object to a PNG file
//        byte[] bytes = texture.EncodeToPNG();

//        // Save the PNG file to the application data path
//        string path = UnityEngine.Application.dataPath + "/drawing.png";
//        File.WriteAllBytes(path, bytes);
//        UnityEngine.Debug.Log("Saved to " + path);
//    }
//}























