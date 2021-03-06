﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MegaWeapon01 : MonoBehaviour
{
    public Transform MegaCannonFirepoint01;
    public Transform MegaCannonFirepoint02;
    public Transform MegaCannonFirepoint03;
    public GameObject bulletPrefab;
    Vector3 targetPosition;

    void Start()
    {
        Debug.Log("MegaWeapon01");

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
            Instantiate(bulletPrefab, MegaCannonFirepoint02.position, Quaternion.LookRotation(ray.direction));
            Instantiate(bulletPrefab, MegaCannonFirepoint03.position, Quaternion.LookRotation(ray.direction));
        }
    }
}
