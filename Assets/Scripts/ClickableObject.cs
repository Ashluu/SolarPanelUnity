using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public GameObject panel; // Reference to the panel GameObject

    void Update()
    {
        // Check for right-click anywhere
        if (Input.GetMouseButtonDown(1))
        {
            // Deactivate the panel if it's active
            if (panel != null && panel.activeSelf)
            {
                panel.SetActive(false);
            }
        }
    }

    private void OnMouseDown()
    {
        // This code will be executed when the object is clicked
        Debug.Log("Object Clicked: " + gameObject.name);
        // Activate the panel when the object is clicked
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }
}
