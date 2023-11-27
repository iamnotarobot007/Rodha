using UnityEngine;

public class PlayerSprite : MonoBehaviour
{
    public Color newColor;
    public GameObject playerObject;
    public Score Score;

    public void ChangePlayerSprite()
    {
        if (Score.StarNum >= 20)
        {
            SpriteRenderer playerSpriteRenderer = playerObject.GetComponent<SpriteRenderer>();
            if (playerSpriteRenderer != null)
            {

                playerSpriteRenderer.color = newColor;

            }
        }
    }
}