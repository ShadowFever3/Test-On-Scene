using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScipt : MonoBehaviour
{
    [SerializeField]
    Canvas canvas;

    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Pause()
    {
        Time.timeScale = 0;
        isPaused = true;
        canvas.enabled = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
        canvas.enabled = false;
    }
}
