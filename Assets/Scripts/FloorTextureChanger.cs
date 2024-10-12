using UnityEngine;
using UnityEngine.UI; // For UI elements

public class FloorTextureChanger : MonoBehaviour
{
    public Renderer floorRenderer;   // Assign the floor object (or material) in the Inspector
    public Texture[] textures;       // Array of texture options to switch between
    public Button[] textureButtons;  // Buttons to change texture

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
            // Set the selected texture to the floor material
            floorRenderer.material.mainTexture = textures[index];
        }
    }
}
