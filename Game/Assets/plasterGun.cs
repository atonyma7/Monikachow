using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plasterGun : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject projectilePreFab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot() 
    {
        Instantiate(projectilePreFab, Firepoint.position, Firepoint.rotation);
    }
}
