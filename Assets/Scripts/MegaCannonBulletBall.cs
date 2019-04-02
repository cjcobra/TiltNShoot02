using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaCannonBulletBall : MonoBehaviour
{
   // public float delay = .3f;
    public float speed = 5f;  //CJ 20f
   // public float force = 700f;
   // public float radius = 5f;
    public Rigidbody rb;

    //float countdown;
 //   bool hasExploded = false;

    public GameObject explosionEffect;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("MegaCannonBulletBall");

        //countdown = delay;
        rb.velocity = transform.forward * speed;
    }

}
