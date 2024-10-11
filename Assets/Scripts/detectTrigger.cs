using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectTrigger : MonoBehaviour
{
    public GameObject componentsUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // when the XR Origin will collide with the planet colliders the following things will happen
        if (other.gameObject.name == "marker")
        {
            other.gameObject.SetActive(false);
            componentsUI.SetActive(true);
        }
    }
}
