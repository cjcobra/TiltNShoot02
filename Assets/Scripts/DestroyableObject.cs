using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyableObject : MonoBehaviour
{

    public float forceRequired = 50.0f;

    private void Start()
    {
        Debug.Log("DestroyableObject");

    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.impulse.magnitude > forceRequired)
        {
            Destroy(gameObject);
        }
    }



}
