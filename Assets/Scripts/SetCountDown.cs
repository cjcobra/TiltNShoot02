using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCountDown : MonoBehaviour
{

    private GameManagerScript GMS;

    private void Start()
    {
        Debug.Log("SetCountDown");

    }

    public void SetCountDownNow()
    {
        GMS = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        GMS.counterDownDone = true;


    }



}
