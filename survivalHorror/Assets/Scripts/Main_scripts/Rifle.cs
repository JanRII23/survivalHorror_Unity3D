using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    
    [Header("Rifle Things")]
    public Camera cam;
    public float givedamageOf = 10f;
    public float shootingRange = 100f;

    [Header("Right Effects")]
    public ParticleSystem muzzleSpark;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    private void Shoot()
    {
        muzzleSpark.Play();
        RaycastHit hitInfo;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, shootingRange))
        {
            Debug.Log(hitInfo.transform.name);

            ObjectTohit objectHit = hitInfo.transform.GetComponent<ObjectTohit>();
            if (objectHit != null)
            {
                objectHit.ObjectHitDamage(givedamageOf);
            }

        }
    }

}
