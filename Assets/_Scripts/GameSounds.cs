using System.Collections;
using System.Collections.Generic;
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

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void ClickSound()
    {
        _audioSource.PlayOneShot(_clickSound);
    }

    public void OutOfPipeSound()
    {
        _audioSource.PlayOneShot(_outOfPipeSound);
    }

    public void PickSound()
    {
        _audioSource.PlayOneShot(_pickSound);
    }

    public void LoseSound()
    {
        _audioSource.PlayOneShot(_loseSound);
    }

    public void GameOverSound()
    {
        _audioSource.PlayOneShot(_gameOverSound);
    }

    public void WinSound()
    {
        _audioSource.PlayOneShot(_winSound);
    }
}
