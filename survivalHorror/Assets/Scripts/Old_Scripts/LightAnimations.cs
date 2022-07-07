using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightAnimations : MonoBehaviour
{
    public int LightMode;
    public GameObject Light;
  
    void Update()
    {
        if(LightMode == 0)
        {
            StartCoroutine(AnimateLight());
        }
    }

    IEnumerator AnimateLight()
    {
        LightMode = Random.Range(1, 4);
        if (LightMode == 1)
        {
            Light.GetComponent<Animation>().Play("LampAnim1");
        }else if (LightMode == 2)
        {
            Light.GetComponent<Animation>().Play("LampAnim2");

        }
        else
        {
            Light.GetComponent<Animation>().Play("LampAnim3");
        }

        yield return new WaitForSeconds(0.99f);

        LightMode = 0;
    }
}
