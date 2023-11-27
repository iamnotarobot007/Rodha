using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    public GameObject popupPanel;

    void Start()
    {
        // Ensure the pop-up is initially hidden
        popupPanel.SetActive(false);
    }

    // Call this method to show the pop-up
    public void ShowPopup()
    {
        popupPanel.SetActive(true);
    }

    // Call this method to hide the pop-up
    public void HidePopup()
    {
        popupPanel.SetActive(false);
    }
}
