using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinBox : MonoBehaviour
{

    private void Start()
    {
        Debug.Log("WinBox");

    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "BulletBall")
        {
            // Victory
            LevelManager.Instance.Victory();

        }
    }




}
