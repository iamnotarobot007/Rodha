using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    #region Public Variables
    public Canvas homeCanvas;
    public Canvas shopCanvas;
    public Canvas settingCanvas;
    public PlayerController playerController;
    [SerializeField] Animator transition;
    #endregion


    #region Button Click Handlers
    public void StartGame()
    {
       // ScreenManager.instance.SwitchScreen(ScreenType.Canvas);
        //transition.SetTrigger("Start");
        //transition.SetTrigger("End");
        // await System.Threading.Tasks.Task.Delay(1000);
        // homeCanvas.transform.DOMoveY(1000f,3);
        homeCanvas.enabled = false;
        GroundSpawner.instance.StartGame();
        playerController.ToggleGamePause();
        SoundManager.inst.PlaySound(SoundName.s2);

       


    }
   

    public void OnShopClicked()
    {

        ScreenManager.instance.SwitchScreen(ScreenType.Shop);
        homeCanvas.enabled = false;
        SoundManager.inst.PlaySound(SoundName.s2);

    }
    public void OnSettingClicked()
    {

        ScreenManager.instance.SwitchScreen(ScreenType.Setting);
        homeCanvas.enabled = false;
        SoundManager.inst.PlaySound(SoundName.s2);

    }

    public void OnLevelClicked()
    {

        ScreenManager.instance.SwitchScreen(ScreenType.Level);
        homeCanvas.enabled = false;
       

    }
    public void OnBackClicked()
    {

        ScreenManager.instance.SwitchScreen(ScreenType.Home);
        settingCanvas.enabled = false;
        shopCanvas.enabled = false;
        SoundManager.inst.PlaySound(SoundName.click);

    }
    #endregion
}
