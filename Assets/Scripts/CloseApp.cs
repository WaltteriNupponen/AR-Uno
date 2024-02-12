using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CloseApp : MonoBehaviour
{
    // Reference to the button
    public Button closeButton;

    // Called when the script instance is being loaded
    void Start()
    {
        // Add listener to the button
        closeButton.onClick.AddListener(CloseApplication);
    }

    private void CloseApplication()
    {
        // Quit the application (may not work with all VR games)
        Application.Quit();
    }
}
