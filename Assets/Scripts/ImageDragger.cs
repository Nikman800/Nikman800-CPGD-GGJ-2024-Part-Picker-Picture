using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public interface ICustomDrag
{
    void OnCurrentDrag();
}

public class ImageDragger : MonoBehaviour, IDragHandler
{
    [SerializeField] private GameObject image;
    private ICustomDrag drag;
    // Start is called before the first frame update
    void Start()
    {
        drag = image.GetComponent<ICustomDrag>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        drag.OnCurrentDrag();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
