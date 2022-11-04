using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance;

    [SerializeField]
    AudioSource bgmSource, sfxSource;

    private void Awake()
    {
        Instance = this;
    }

    public void PlayBGM(AudioClip clip)
    {
        bgmSource.clip = clip;
        bgmSource.Play();
    }

    public void PlaySound(AudioClip clip, bool randomizePitch)
    {
        if (randomizePitch) sfxSource.pitch = Random.Range(1f, 2f);
        else sfxSource.pitch = 1;
        sfxSource.PlayOneShot(clip);
    }

}
