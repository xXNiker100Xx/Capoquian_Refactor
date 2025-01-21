using UnityEngine;

public class WallCollision : MonoBehaviour
{

    [Header("Collision")]
    [SerializeField] LayerMask WallLayer;
     private SoundFX SFX;
     private VisualFX VFX;

    private void Awake()
    {
        SFX = GetComponent<SoundFX>();
        VFX = GetComponent<VisualFX>();
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if ((WallLayer.value & (1 << hit.gameObject.layer)) > 0)
        {
            Debug.Log("Wall touched");
            SFX.PlayAudioCLip();
            VFX.ParticleEffect();
           
        }
    }
}
