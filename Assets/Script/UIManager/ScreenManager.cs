using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    #region Singleton
    public static ScreenManager instance;
    #endregion
    
    #region Public Variables
    public BaseScreen[] screens;
    public BaseScreen currentScreen;
   
    #endregion

    #region Unity Callbacks
    private void Awake()
    {
        instance = this;
    }
    #endregion

    #region Screen Switching
    public void SwitchScreen(ScreenType screenType)
    {
        currentScreen.canvas.enabled = false;
        foreach (BaseScreen bs in screens)
        {
            if (bs.screenType == screenType)
            {
                bs.canvas.enabled = true;
                currentScreen = bs;
                break;
            }
        }
    }
    #endregion
}



public enum ScreenType
{
    Home, Pause, GameOver, Shop, Setting,Canvas,Level
}

[System.Serializable]
public class BaseScreen
{
    #region Public Variables
    public ScreenType screenType;
    public Canvas canvas;
    #endregion
}
