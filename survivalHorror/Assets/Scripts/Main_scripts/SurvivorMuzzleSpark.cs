using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SurvivorMuzzleSpark : MonoBehaviour
{

    [Header("Rifle Effects")]
    public ParticleSystem muzzleSpark;

    // Update is called once per frame
    void Update()
    {
        muzzleSpark.Play();

    }


}
