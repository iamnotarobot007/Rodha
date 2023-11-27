using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour
{
    #region Public Variables
    public Canvas gameOverCanvas;
    public Score score;
    public PlayerController playerController;
    #endregion

    #region Button Click Handlers
    public void OnRestartClickedGameOver()
    {
        gameOverCanvas.enabled = false;
        playerController.isGamePaused = false;

        GroundSpawner.instance.StartGame();
       // score.ResetScore();
        SoundManager.inst.PlaySound(SoundName.s2);

    }

    public void OnHomeClickedGameOver()
    {
        gameOverCanvas.enabled = false;
        Debug.Log("home");
        playerController.isGamePaused = true;
      
        ScreenManager.instance.SwitchScreen(ScreenType.Home);
      
        GroundSpawner.instance.StartGame();
        score.ResetScore();
        SoundManager.inst.PlaySound(SoundName.s2);

    }
    #endregion
}
