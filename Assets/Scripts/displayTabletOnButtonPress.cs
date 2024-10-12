using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class displayTabletOnButtonPress : MonoBehaviour
{
    public GameObject tablet;  // Assign the tablet object in the Inspector
    public InputDeviceCharacteristics controllerCharacteristics;  // Set to Left Hand in the Inspector
    bool isXButtonPressed = false;
    private InputDevice targetDevice;
    private bool isTabletVisible = false; // Track whether the tablet is visible or not

    void Start()
    {
        // Try to find the controller based on characteristics (left-hand controller)
        InitializeController();
    }

    void InitializeController()
    {
        // Get the desired controller (in this case, the left-hand controller)
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesWithCharacteristics(controllerCharacteristics, devices);

        if (devices.Count > 0)
        {
            targetDevice = devices[0];
        }
    }

    void Update()
    {
        // If the controller is not initialized, try to find it
        if (!targetDevice.isValid)
        {
            InitializeController();
        }

        // Check if the X button is pressed
        
        if (targetDevice.TryGetFeatureValue(CommonUsages.primaryButton, out isXButtonPressed) && isXButtonPressed)
        {
            tablet.SetActive(true);
        }
        else
        {
            tablet.SetActive(false);
        }
    }
}
