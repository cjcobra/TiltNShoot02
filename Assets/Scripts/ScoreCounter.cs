﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public static int scoreAmount;
    private Text scoreCounter;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("ScoreCounter");


        scoreCounter = GetComponent<Text>();
      // cj  scoreAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(scoreAmount);

        scoreCounter.text = "Blocks: " + scoreAmount;
    }
}
