using UnityEngine;

public class PanelController : MonoBehaviour
{
    // Reference to the TextMeshPro component
    public TMPro.TextMeshProUGUI tmpText;

    // This method is called when the panel needs to be opened
    public void OpenPanel()
    {
        // Activate the panel
        gameObject.SetActive(true);

        // Ensure that the TMP text component is not null
        if (tmpText != null)
        {
            // Activate the TMP text component
            tmpText.gameObject.SetActive(true);
        }
    }

    // This method is called when the panel needs to be closed
    public void ClosePanel()
    {
        // Deactivate the panel
        gameObject.SetActive(false);
    }
}
