using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiflePickUp : MonoBehaviour
{


    //when refining later make sure to have the animations be timed correctly

    [Header("Rifle's")]
    public GameObject PlayerRifle;
    public GameObject PickUpRifle;
    public PlayerPunch playerPunch;

    [Header("Rifle Assign")]
    public PlayerScript player;
    private float radius = 2.5f;
    public Animator animator;
    private float nextTimeToPunch = 0f;
    public float punchCharge = 15f;

    private void Awake()
    {
        PlayerRifle.SetActive(false);

    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToPunch)
        {
            animator.SetBool("Punch", true);
            animator.SetBool("Idle", false);
            nextTimeToPunch = Time.time + 1f / punchCharge;
            playerPunch.Punch();
        }
        else
        {
            animator.SetBool("Punch", false);
            animator.SetBool("Idle", true);
        }


        if(Vector3.Distance(transform.position,player.transform.position) < radius)
        {
            if (Input.GetKeyDown("f"))
            {
                PlayerRifle.SetActive(true);
                PickUpRifle.SetActive(false);

                //sound

                //objective
            }
        }
    }
}