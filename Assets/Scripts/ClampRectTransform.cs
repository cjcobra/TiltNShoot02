﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClampRectTransform : MonoBehaviour
{
    public float padding = 5.0f;
    public float elementSize = 128.0f;
    public float viewSize = 408.0f;

    private RectTransform rt;
    private int amountElements;
    private float contentSize;

    private void Start()
    {
        Debug.Log("ClampRectTransform");

        rt = GetComponent<RectTransform>();
    }

    private void Update()
    {
        // Clamp the rect transform in the menu screen

        amountElements = rt.childCount;
        contentSize = ((amountElements * (elementSize + padding)) - viewSize) * rt.localScale.x;

        if (rt.localPosition.x > padding)
            rt.localPosition = new Vector3(padding, rt.localPosition.y, rt.localPosition.z);
        else if(rt.localPosition.x < -contentSize )
            rt.localPosition = new Vector3(-contentSize, rt.localPosition.y, rt.localPosition.z);
    }


}
