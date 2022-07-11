using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPunch : MonoBehaviour
{
    [Header("Player Punch Var")]
    public Camera cam;
    public float giveDamageOf = 10f;
    public float punchingRange = 5f;

    [Header("Punch Effects")]
    public GameObject WoodedEffect;
    public GameObject GoreEffect;

    public void Punch()
    {
        RaycastHit hitInfo;

        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, punchingRange))
        {
            Debug.Log(hitInfo.transform.name);

            ObjectTohit objectHit = hitInfo.transform.GetComponent<ObjectTohit>();
            Zombie1 zombie1 = hitInfo.transform.GetComponent<Zombie1>();
            if (objectHit != null)
            {
                objectHit.ObjectHitDamage(giveDamageOf);
                /*GameObject WoodGo = Instantiate(WoodedEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                Destroy(WoodGo, 1f);*/
            }
            else if (zombie1 != null)
            {
                zombie1.zombieHitDamage(giveDamageOf);
               /* GameObject goreFffectGo = Instantiate(GoreEffect, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
                Destroy(goreFffectGo, 1f);*/
            }
        }
    }


}
