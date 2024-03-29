using UnityEngine;

public class PanelController : MonoBehaviour
{
    // This method is called when the panel needs to be opened
    public void OpenPanel()
    {
        gameObject.SetActive(true); // Activate the panel
    }

    // This method is called when the panel needs to be closed
    public void ClosePanel()
    {
        gameObject.SetActive(false); // Deactivate the panel
    }
}
