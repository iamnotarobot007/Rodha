using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayScreen : MonoBehaviour
{
    #region Public Variables
    public Canvas pauseCanvas;
    public CountDownCanvas countdownCanvas;
    public PlayerController playerController;
    public Score score;
    #endregion

    #region Button Click Handlers
    public void OnPauseButtonClicked()
    {
        // Time.timeScale = 0f;
        playerController.ToggleGamePause();
        pauseCanvas.enabled = true;
        playerController.rb.velocity = Vector3.zero;
        SoundManager.inst.PlaySound(SoundName.click);
    }

    public async void OnPlayButtonClicked()
    {
        pauseCanvas.enabled = false;
        SoundManager.inst.PlaySound(SoundName.s2);
        countdownCanvas.StartCountdown();
        await System.Threading.Tasks.Task.Delay(2000);
        // Time.timeScale = 1f;
        playerController.ToggleGamePause();
    }

    public void OnRestartClicked()
    {
        pauseCanvas.enabled = false;
        // Time.timeScale = 1f;
        playerController.ToggleGamePause();
     //   GroundSpawner.instance.DestroyChildPrefav();
        GroundSpawner.instance.StartGame();
        score.ResetScore();
        SoundManager.inst.PlaySound(SoundName.s2);
    }

    public void OnHomeClicked()
    {
        ScreenManager.instance.SwitchScreen(ScreenType.Home);
        playerController.isGamePaused = true;
        pauseCanvas.enabled = false;
        score.ResetScore();
        SoundManager.inst.PlaySound(SoundName.s2);
    }
    #endregion
}
