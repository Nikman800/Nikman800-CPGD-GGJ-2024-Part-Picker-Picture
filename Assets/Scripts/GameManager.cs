using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private string[] categories = {"foot", "head", "arm", "leg", "hand", "torso"};
    private float delay = 3f;
    private float timer = 10f;
    [SerializeField] private TextMeshProUGUI drawing;
    [SerializeField] private GameObject colorPicker;
    [SerializeField] private GameObject pen;
    private bool countDown = true, end = true;
    // Start is called before the first frame update
    void Start()
    {
        colorPicker.SetActive(false);
        pen.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (countDown)
        {
            if (delay < 0)
            {
                countDown = false;
                drawing.text = categories[UnityEngine.Random.Range(0, categories.Length)];
                colorPicker.SetActive(true);
                pen.SetActive(true);
            }
            delay -= Time.deltaTime;
        }
        else
        {
            if (timer < 0 && end)
            {
                drawing.text = "Time's up!";
                colorPicker.SetActive(false);
                pen.SetActive(false);
                end = false;
            }
            timer -= Time.deltaTime;
        }
        
    }
}
