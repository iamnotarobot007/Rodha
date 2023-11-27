using UnityEngine;
using UnityEngine.UI;

public class SoundSlider : MonoBehaviour
{
    public SoundManager soundManager;

    private void Start()
    {

        soundManager = GameObject.FindObjectOfType<SoundManager>();
        GetComponent<Slider>().value = 0.5f;
        GetComponent<Slider>().onValueChanged.AddListener(ChangeVolume);

    }

    private void ChangeVolume(float volume)
    {
        soundManager.SetVolume(volume);
    }

}