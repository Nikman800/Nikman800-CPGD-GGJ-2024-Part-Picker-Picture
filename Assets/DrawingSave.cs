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
using UnityEngine.UI;

public class DrawingSave : MonoBehaviour
{
    public DrawWithMouse drawWithMouse;
    public RenderTexture renderTexture;
    public Camera renderCamera;
    [SerializeField] private Button next;
    
    private bool ColorApproxBG(Color color)
    {
        float lower = 150f / 255f;
        float upper = 175f / 255f;
        return color.r == color.g && color.g == color.b &&
            color.r > lower && color.r < upper &&
            color.g > lower && color.g < upper &&
            color.b > lower && color.b < upper;
    }

    private void Awake()
    {
        next.gameObject.SetActive(false);
    }
    
    public void SaveDrawing()
    {
        next.gameObject.SetActive(true);
        // Convert the render texture to a Texture2D object
        Texture2D texture = new Texture2D(renderTexture.width - 535, renderTexture.height, TextureFormat.ARGB32, false);
        RenderTexture.active = renderTexture;
        texture.ReadPixels(new Rect(535, 0, renderTexture.width, renderTexture.height), 0, 0);
        texture.Apply();

        // Remove background pixels
        for (int row = 0; row < texture.height; row++)
    public Camera renderCamera;
    
            for (int col = 0; col < texture.width; col++)
            {
                if (ColorApproxBG(texture.GetPixel(col, row)))
                    texture.SetPixel(col, row, new(0f, 0f, 0f, 0f));
            }
        }
        texture.Apply();

        // Encode the Texture2D object to a PNG file
        byte[] bytes = texture.EncodeToPNG();

        // Save the PNG file to the application data path with the provided filename
        
        string path = UnityEngine.Application.dataPath + "/Resources/" + SceneManager.GetActiveScene().name + ".png";
        File.WriteAllBytes(path, bytes);
        UnityEngine.Debug.Log("Saved to " + path);
    }

    public void NextDrawing()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
























