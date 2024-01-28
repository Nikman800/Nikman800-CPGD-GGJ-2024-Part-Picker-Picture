using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Art : MonoBehaviour, ICustomDrag
{
    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnCurrentDrag()
    {
        rectTransform.position = Input.mousePosition;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
