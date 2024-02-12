using UnityEngine;

public class ColorRecognition : MonoBehaviour
{
    // Example target color in RGB
    public Color targetColorRGB;

    void Update()
    {
        // Convert target color to HSV
        Color.RGBToHSV(targetColorRGB, out float hue, out float saturation, out float value);

        // Use hue, saturation, and value for color recognition
        Debug.Log("Hue: " + hue + ", Saturation: " + saturation + ", Value: " + value);
    }
}
