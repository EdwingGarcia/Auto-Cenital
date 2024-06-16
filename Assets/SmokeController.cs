using UnityEngine;

public class SmokeController : MonoBehaviour
{
    public ParticleSystem smokeParticleSystem;
    public VehicleController vehicleController;

    void Update()
    {
        if (vehicleController.IsMoving())
        {
            if (!smokeParticleSystem.isPlaying)
            {
                smokeParticleSystem.Play();
            }
        }
        else
        {
            if (smokeParticleSystem.isPlaying)
            {
                smokeParticleSystem.Stop();
            }
        }
    }
}
