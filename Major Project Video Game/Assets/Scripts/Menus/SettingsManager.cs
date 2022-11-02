using UnityEngine;
using UnityEngine.Audio;

public class SettingsManager : MonoBehaviour // For the Settings section of the Main and Pause Menu of the game
{
    // Game's Main Volume And Sound Effects
    public AudioMixer volumeMixer;
    public AudioMixer soundEffectsMixer;

    //public void SetFullScreen(bool isFullScreen) // Able to change the video game to fullscreen or to windowed
    //{
        //Screen.fullScreen = isFullScreen;
   // }

    public void SetVolume(float volume) // Able to change the settings of the Volume of the game
    {
        volumeMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);

    }

    public void SetSoundEffects(float soundEffects) // Able to change the settings of the Sound Effects of the game
    {
        soundEffectsMixer.SetFloat("SoundEffects", Mathf.Log10(soundEffects) * 20);

    }

    public void SetQuality(int qualityOptions) // Able to change the settings of the graphics of the game
    {
        QualitySettings.SetQualityLevel(qualityOptions);
    }
}