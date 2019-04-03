using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaWeapon03 : MonoBehaviour
{
    public Transform MegaCannonFirepoint01;
    public GameObject bulletPrefab;
    Vector3 targetPosition;

    void Start()
    {
        Debug.Log("MegaWeapon03");

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000))
        {
            targetPosition = hit.point;

            // shooting logic
            Instantiate(bulletPrefab, MegaCannonFirepoint01.position, Quaternion.LookRotation(ray.direction));

        }
    }
}


