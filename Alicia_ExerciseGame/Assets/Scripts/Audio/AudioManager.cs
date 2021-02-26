using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioMixer audioMixer;
    public Slider volSlider;
    public bool doesAudioFade;

    public void Start()
    {
        
        audioSource.volume = .35f;
        volSlider.value = audioSource.volume;
    }

    public void SetAudioLevel(float sliderValue)
    {
        //Setting the volume slider to mathmatically set itself to -80db and 0 on a logorithmic scale.
        audioMixer.SetFloat("MusicVolume", Mathf.Log10(sliderValue) * 20);
    }

}
