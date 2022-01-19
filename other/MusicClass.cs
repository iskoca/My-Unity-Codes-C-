using UnityEngine;
using UnityEngine.UI;
public class MusicClass : MonoBehaviour
{
    private AudioSource _audioSource;
    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayMusic()
    {
        if (_audioSource.isPlaying) return;
        Play();
    }

    public void StopMusic()
    {
        _audioSource.Stop();
    }
    public void Mute()
    {
        _audioSource.Pause();
    }
    public void Play()
    {
        _audioSource.Play();
    }

}