using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloorTextureChanger : MonoBehaviour
{
    public Renderer floorRenderer;   // Assign the floor material in the Inspector
    public Texture[] textures;       // Array of texture options to switch between
    public Button[] textureButtons;  // Buttons to change texture in UI

    void Start()
    {
        // Add listeners to buttons, each button changes to a specific texture
        for (int i = 0; i < textureButtons.Length; i++)
        {
            int index = i;  // Local variable to capture index
            textureButtons[i].onClick.AddListener(() => ChangeTexture(index));
        }
    }

    public void ChangeTexture(int index)
    {
        if (index >= 0 && index < textures.Length)
        {
            // selected texture will be assigned to the floor material
            floorRenderer.material.mainTexture = textures[index];
        }
    }
}
