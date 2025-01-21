using UnityEngine;

public class VisualFX : MonoBehaviour
{
    [Header("Effects")]
    [SerializeField] private ParticleSystem partSys;

    public void ParticleEffect()
    {
        partSys.Play();
    }
}
