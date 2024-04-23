using UnityEngine;

public class GameSounds : MonoBehaviour
{
    [SerializeField] private AudioClip _clickSound;
    [SerializeField] private AudioClip _outOfPipeSound;
    [SerializeField] private AudioClip _pickSound;
    [SerializeField] private AudioClip _loseSound;
    [SerializeField] private AudioClip _gameOverSound;
    [SerializeField] private AudioClip _winSound;

    private AudioSource _audioSource;
    public static bool CanVibro;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();

        Vibration.Init();
        string vibro = PlayerPrefs.GetString("vibro", "");
        if (vibro == "" || vibro == "on") CanVibro = true;
        else CanVibro = false;
    }

    public void ClickSound()
    {
        if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Light);
        _audioSource.PlayOneShot(_clickSound);
    }

    public void OutOfPipeSound()
    {
        if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Medium);
        _audioSource.PlayOneShot(_outOfPipeSound);
    }

    public void PickSound()
    {
        if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Rigid);
        _audioSource.PlayOneShot(_pickSound);
    }

    public void LoseSound()
    {
        if (CanVibro) Vibration.VibrateIOS(NotificationFeedbackStyle.Error);
        _audioSource.PlayOneShot(_loseSound);
    }

    public void GameOverSound()
    {
        if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Heavy);
        _audioSource.PlayOneShot(_gameOverSound);
    }

    public void WinSound()
    {
        if (CanVibro) Vibration.VibrateIOS(ImpactFeedbackStyle.Heavy);
        _audioSource.PlayOneShot(_winSound);
    }
}
