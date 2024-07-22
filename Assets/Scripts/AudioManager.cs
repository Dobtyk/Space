using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }

    [SerializeField] AudioMixer _audioMixer;
    [SerializeField] AudioSource _backgroundMusic;

    public bool MusicIsMuted;
    public bool EffectsIsMuted;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ToggleSound(string nameParameter)
    {
        _audioMixer.GetFloat(nameParameter, out float volume);
        _audioMixer.SetFloat(nameParameter, volume == 0 ? -80 : 0);
    }

    public void ToggleMusic(AudioClip clip)
    {
        _backgroundMusic.Stop();
        _backgroundMusic.clip = clip;
        _backgroundMusic.Play();
    }
}