using UnityEngine;

public class SoundFX : MonoBehaviour
{
    [Header("Audio")]
    [SerializeField] private AudioSource audioSource;

    public void PlayAudioCLip()
    {
        audioSource.Play();
    }

}
