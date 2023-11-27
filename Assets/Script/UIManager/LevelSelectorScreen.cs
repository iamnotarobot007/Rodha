using UnityEngine;

public class LevelSelectorScreen : MonoBehaviour
{
    #region Public Variables
    public Canvas LevelSelector;
    public PlayerController playerController;

    #endregion

    #region Button Click Handlers
    public void OnLevelButtonClick()
    {
        LevelSelector.enabled = false;
        playerController.ToggleGamePause();
    }


    #endregion
}