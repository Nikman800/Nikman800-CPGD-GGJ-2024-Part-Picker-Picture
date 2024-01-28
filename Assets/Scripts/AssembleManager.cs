using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AssembleManager : MonoBehaviour
{
    private Texture image;
    [SerializeField] private RawImage display;
    private float delay = 3f;
    private bool displayed = false;
    // Start is called before the first frame update
    void Awake()
    {
        image = Resources.Load("drawing", typeof(Texture)) as Texture;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       if (!displayed)
        {
            if (delay < 0)
            {
                display.texture = image;
                displayed = true;
            }
            delay -= Time.deltaTime;
        }
    }
}
