using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BFirstTrigger : MonoBehaviour
{
    public GameObject TextBox;
    public GameObject Spotlight;

    void OnTriggerEnter()
    {
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        TextBox.GetComponent<Text>().text = "There is a gun on that table.";
        Spotlight.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        TextBox.GetComponent<Text>().text = "";
        

    }

    //consider stopping player movement?
}
