using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class grabsnap : MonoBehaviour
{
    public GameObject thisMarker; // marker identifying the object
    public GameObject ghost; // ghost guided animation
    public GameObject successsound; // success sound
    public GameObject nextComponent; // next assembly component
    public GameObject nextGhost; // next guided ghost animation
    public GameObject nextMarker; // next marker to be activated
    public GameObject checkmark; // completion checkmark in the checklist
    private AudioSource successaudiosource;
    private XRGrabInteractable interactable;

    // Start is called before the first frame update
    void Start()
    {
        //giving reference to components
        interactable = GetComponent<XRGrabInteractable>(); 
        successaudiosource=successsound.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if(interactable.isSelected)
        {
            // the object marker will be deactivated once the component is grabbed
            thisMarker.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // if the component collides with the ghost marker collider
        if (other.gameObject == ghost)
            {
                successaudiosource.Play();
                ghost.SetActive(false);
                GetComponent<BoxCollider>().enabled = false;
                GetComponent<XRGrabInteractable>().enabled = false;
                Destroy(GetComponent<Rigidbody>());
                transform.position = ghost.transform.position;
                transform.rotation = ghost.transform.rotation;
                checkmark.SetActive(true);
                if (!(nextGhost.gameObject.name== "Assembly Complete"))
                {
                    nextComponent.GetComponent<BoxCollider>().enabled = true;
                    nextComponent.GetComponent<XRGrabInteractable>().enabled=true;
                    nextComponent.GetComponent<AudioSource>().Play();
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
