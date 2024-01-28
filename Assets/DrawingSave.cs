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
//        Texture2D texture = new Texture2D(renderTexture.width-535, renderTexture.height, TextureFormat.RGB24, false);
//        RenderTexture.active = renderTexture;
//        texture.ReadPixels(new Rect(535, 0, renderTexture.width, renderTexture.height), 0, 0);
//        texture.Apply();

//        // Encode the Texture2D object to a PNG file
//        byte[] bytes = texture.EncodeToPNG();

//        // Save the PNG file to the application data path
//        string path = UnityEngine.Application.dataPath + "/drawing.png";
//        File.WriteAllBytes(path, bytes);
//        UnityEngine.Debug.Log("Saved to " + path);
//    }
//}


using UnityEngine;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;
using UnityEngine.SceneManagement;

public class DrawingSave : MonoBehaviour
{
    public DrawWithMouse drawWithMouse;
    public RenderTexture renderTexture;
    public Camera renderCamera;

    public void SaveDrawing()
    {
        // Convert the render texture to a Texture2D object
        Texture2D texture = new Texture2D(renderTexture.width - 535, renderTexture.height, TextureFormat.RGB24, false);
        RenderTexture.active = renderTexture;
        texture.ReadPixels(new Rect(535, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture.Apply();

        // Encode the Texture2D object to a PNG file
        byte[] bytes = texture.EncodeToPNG();

        // Save the PNG file to the application data path with the provided filename
        
        string path = UnityEngine.Application.dataPath + "/Resources/" + SceneManager.GetActiveScene().name + ".png";
        File.WriteAllBytes(path, bytes);
        UnityEngine.Debug.Log("Saved to " + path);
    }
}
























