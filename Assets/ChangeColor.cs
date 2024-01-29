using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public DrawWithMouse drawWithMouse;

    // Attach this function to the button's OnClick event in the Unity Editor
    //the colors are red, blue, yellow, green, orange, purple, pink, black, white, gray, brown, cyan

    public void ChangeColorToRed()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(Color.red);
        }
    }
    public void ChangeColorToBlue()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(Color.blue);
        }
    }
    public void ChangeColorToYellow()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(Color.yellow);
        }
    }
    public void ChangeColorToGreen()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(Color.green);
        }
    }
    public void ChangeColorToOrange()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(new Color(255f / 255f, 165f / 255f, 0f / 255f));
        }
    }
    public void ChangeColorToPurple()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(new Color(128f / 255f, 0f, 128f / 255f));
        }
    }
    public void ChangeColorToPink()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(new Color(255f / 255f, 192f / 255f, 203f / 255f));
        }
    }
    public void ChangeColorToBlack()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(Color.black);
        }
    }
    public void ChangeColorToWhite()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(Color.white);
        }
    }
    public void ChangeColorToGray()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(Color.gray);
        }
    }
    public void ChangeColorToBrown()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(new Color(165f / 255f, 42f / 255f, 42f / 255f));
        }
    }
    public void ChangeColorToCyan()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(Color.cyan);
        }
    }

    public void ChangeColorToBackground()
    {
        if (drawWithMouse != null)
        {
            drawWithMouse.ChangeColor(new(212f / 255f, 212f / 255f, 212f / 255f));
        }
    }
    
    
}
