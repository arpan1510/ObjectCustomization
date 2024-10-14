using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectTrigger : MonoBehaviour
{
    public GameObject componentsUI;

    private void OnTriggerEnter(Collider other)
    {
        // when the XR Origin will collide with the marker collider the following things will happen
        if (other.gameObject.name == "marker")
        {
            other.gameObject.SetActive(false); //disable the marker
            componentsUI.SetActive(true); //component UI will get enabled
        }
    }
}
