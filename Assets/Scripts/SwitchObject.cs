using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchObject : MonoBehaviour
{
    public Transform target;

    private void Start()
    {
        Debug.Log("SwitchObject");

    }

    private void OnCollisionEnter(Collision col)
    {
        if(target !=null)
        Destroy(target.gameObject);
    }


}
