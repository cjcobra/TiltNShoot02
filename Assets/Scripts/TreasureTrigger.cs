﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("TreasureTrigger");

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag.Equals("BulletBall"))
        {
            ScoreCounter.scoreAmount += 50;
        }
    }
}
