using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class grabsnap : MonoBehaviour
{
    public GameObject ghost;
    public GameObject nextComponent;
    public GameObject nextGhost;
    private XRGrabInteractable interactable;
    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
            if (other.gameObject == ghost)
            {
                ghost.SetActive(false);
                GetComponent<BoxCollider>().enabled = false;
                GetComponent<XRGrabInteractable>().enabled = false;
                Destroy(GetComponent<Rigidbody>());
                transform.position = ghost.transform.position;
                transform.rotation = ghost.transform.rotation;
                if(!(nextGhost.gameObject.name== "Assembly Complete"))
                {
                    nextComponent.GetComponent<BoxCollider>().enabled = true;
                    nextComponent.GetComponent<XRGrabInteractable>().enabled=true;
                    nextGhost.SetActive(true);
                }
                else
                {
                    nextComponent.SetActive(true);
                }
                
            }
        
        
    }
}
