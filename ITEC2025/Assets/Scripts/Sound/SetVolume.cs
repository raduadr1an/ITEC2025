using UnityEngine;
using UnityEngine.Audio;

public class SetVolume : MonoBehaviour
{
    public AudioMixer mixer;
    private float volume;
    public AudioSource source;

    public void setLevel(float sliderValue)
    {
        volume = Mathf.Log10(sliderValue) * 20;
        mixer.SetFloat("Volume", volume);
        PlayerPrefs.SetFloat("VolumeLevel", sliderValue);
    }
}