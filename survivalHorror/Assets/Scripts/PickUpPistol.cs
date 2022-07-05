using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class PickUpPistol : MonoBehaviour
{
    [SerializeField]
    private TextMeshPro ActionText;

    public float TheDistance;
    public GameObject ActionDisplay;
    public GameObject FakePistol;
    public GameObject RealPistol;
    public GameObject Spotlight;
    public GameObject ExtraCross;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 2)
        {
            ExtraCross.SetActive(true);
            ActionText.SetText("Pickup Pistol \"E\"");
            ActionDisplay.SetActive(true);
           
        }
        if (Input.GetButtonDown("Action"))
        {
            if (TheDistance <= 2)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionDisplay.SetActive(false);
                ActionDisplay.SetActive(false);
                FakePistol.SetActive(false);
                FakePistol.SetActive(true);
                ExtraCross.SetActive(false);
            }
        }
    }

    private void OnMouseExit()
    {
        ExtraCross.SetActive(false);
        ActionDisplay.SetActive(false);
        ActionText.gameObject.SetActive(false);
    }
}
