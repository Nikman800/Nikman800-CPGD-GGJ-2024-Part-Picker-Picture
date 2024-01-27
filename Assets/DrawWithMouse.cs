using System.Collections.Generic;
using UnityEngine;

public class DrawWithMouse : MonoBehaviour
{
    private List<LineRenderer> lines = new List<LineRenderer>();
    private List<Vector3> currentLinePositions = new List<Vector3>();
    private Color currentColor = Color.black; // Default color is black

    [SerializeField]
    private float minDistance = 0.1f;
    [SerializeField, Range(0.1f, 2f)]
    private float width = 0.1f;

    private void Start()
    {
        CreateNewLine();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 currentPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            currentPosition.z = 0f;

            if (currentLinePositions.Count == 0 || Vector3.Distance(currentPosition, currentLinePositions[currentLinePositions.Count - 1]) > minDistance)
            {
                currentLinePositions.Add(currentPosition);
                UpdateLineRenderer();
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            CreateNewLine();
        }
    }

    private void UpdateLineRenderer()
    {
        lines[lines.Count - 1].positionCount = currentLinePositions.Count;
        lines[lines.Count - 1].SetPositions(currentLinePositions.ToArray());
        lines[lines.Count - 1].startColor = lines[lines.Count - 1].endColor = currentColor;
    }

    private void CreateNewLine()
    {
        GameObject lineObject = new GameObject("Line");
        LineRenderer newLine = lineObject.AddComponent<LineRenderer>();
        newLine.startWidth = newLine.endWidth = width;
        newLine.material = new Material(Shader.Find("Sprites/Default")); // Use a basic material for color support

        lines.Add(newLine);
        currentLinePositions.Clear();
    }

    // Example function for changing the color (you can call this function from UI buttons or other input)
    public void ChangeColor(Color newColor)
    {
        currentColor = newColor;
    }
}
