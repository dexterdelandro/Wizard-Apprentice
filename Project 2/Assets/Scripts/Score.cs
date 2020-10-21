﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject sceneManager;
    public Text displayText;
    private Draw script;


    // Start is called before the first frame update
    void Start()
    {
        script = sceneManager.GetComponent<Draw>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.showScore)
        {
            DisplayText();
        }
    }

    //make text visible
    public void DisplayText()
    {
        displayText.text = "Score:   " + script.scoreFin;
    }
}