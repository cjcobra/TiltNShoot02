﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public AudioSource source;
    public AudioClip explodeblock;
    GameController gc;
    public GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Collectable");

        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        gc.collectable++;

        ScoreCounter.scoreAmount = gc.collectable;  // cj new

    }

    private void Update()
    {
        ScoreCounter.scoreAmount = gc.collectable;  // cj new

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Floor"))
        {
           Destroy(gameObject);
            GameObject impactGo = Instantiate(explosionEffect, transform.position, transform.rotation);
            Destroy(impactGo, 2f);
            source.PlayOneShot(explodeblock);
            // cj   ScoreCounter.scoreAmount += 1;
           gc.collectable--;

        }
    }


}
