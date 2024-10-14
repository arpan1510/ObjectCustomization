using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WallColorChanger : MonoBehaviour
{
    public Renderer wallRenderer;  // Assign the wall material in the Inspector
    public Slider redSlider;       // Slider to adjust red value
    public Slider greenSlider;     // Slider to adjust green value
    public Slider blueSlider;      // Slider to adjust blue value

    void Start()
    {
        // Set default slider values based on current wall color
        Color currentColor = wallRenderer.material.color;
        redSlider.value = currentColor.r;
        greenSlider.value = currentColor.g;
        blueSlider.value = currentColor.b;

        // Add listeners to update the color when slider values change
        redSlider.onValueChanged.AddListener(UpdateColor);
        greenSlider.onValueChanged.AddListener(UpdateColor);
        blueSlider.onValueChanged.AddListener(UpdateColor);
    }

    public void UpdateColor(float value)
    {
        // Update the wall color based on the slider values
        Color newColor = new Color(redSlider.value, greenSlider.value, blueSlider.value);
        wallRenderer.material.color = newColor;
    }
}
