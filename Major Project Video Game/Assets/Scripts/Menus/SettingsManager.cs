using UnityEngine;
using UnityEngine.Audio;

public class SettingsManager : MonoBehaviour // For the Settings section of the Main and Pause Menu of the game
{
    // Game's Main Volume And Sound Effects
    public AudioMixer volumeMixer;
    public AudioMixer soundEffectsMixer;

    public void SetFullScreen(bool isFullScreen) // Able to change the video game to fullscreen
    {
        if (isFullScreen)
        {
            Screen.fullScreen = isFullScreen;
            Resolution[] allResolutions = Screen.resolutions;
            Resolution maxResolution = allResolutions[allResolutions.Length - 1];
            Screen.SetResolution(maxResolution.width, maxResolution.height, true);
        }
    }

    public void Set1080P(bool isWindowScreen1080) // Able to change the video game to 1080p windowed
    {
        if (isWindowScreen1080)
        {
            Screen.SetResolution(1920, 1080, false);
        }
    }

    public void Set720P(bool isWindowScreen720) // Able to change the video game to 720p windowed
    {
        if (isWindowScreen720)
        {
            Screen.SetResolution(1280, 720, false);
        }
    }

    public void Set540P(bool isWindowScreen540) // Able to change the video game to 540p windowed
    {
        if (isWindowScreen540)
        {
            Screen.SetResolution(960, 540, false);
        }
    }

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