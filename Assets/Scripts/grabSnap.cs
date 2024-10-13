using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class grabsnap : MonoBehaviour
{
    public GameObject thisMarker;
    public GameObject ghost;
    public GameObject successsound;
    public GameObject nextComponent;
    public GameObject nextGhost;
    public GameObject nextMarker;
    private AudioSource successaudiosource;
    private XRGrabInteractable interactable;
    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<XRGrabInteractable>();
        successaudiosource=successsound.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(interactable.isSelected)
        {
            thisMarker.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject == ghost)
            {
                successaudiosource.Play();
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
                    nextMarker.SetActive(true);
                    nextGhost.SetActive(true);
                }
                else
                {
                    nextComponent.SetActive(true);
                }
                
            }    
        
        
    }
}
