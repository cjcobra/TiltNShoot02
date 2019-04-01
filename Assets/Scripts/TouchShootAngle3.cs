using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchShootAngle3 : MonoBehaviour
{

    Vector3 targetPosition;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            SetTargetPosition();
        }

               
    }

    void SetTargetPosition ()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000))
        {
            targetPosition  = hit.point;
            this.transform.LookAt(targetPosition);

            //             Instantiate(bulletPrefab, transform.position, transform.rotation);

        }


    }

}
