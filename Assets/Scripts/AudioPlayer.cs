using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [Header("Shooting")]
    [SerializeField] AudioClip shootingAudio;
    [SerializeField][Range(0f, 1f)] float shootingVolume = 1f;

    [Header("Damage")]
    [SerializeField] AudioClip DamageAudio;
    [SerializeField][Range(0f, 1f)] float DamageVolume = 1f;
    public void PlayShootingAudio()
    {
        PlayClip(shootingAudio, shootingVolume);
    }
    public void PlayDamageAudio()
    {
        PlayClip(DamageAudio, DamageVolume);
    }
    void PlayClip(AudioClip clip, float volume)
    {
        if (clip != null)
        {
            Vector3 cameraPos = Camera.main.transform.position;
            AudioSource.PlayClipAtPoint(clip, cameraPos, volume);
        }
    }
}
