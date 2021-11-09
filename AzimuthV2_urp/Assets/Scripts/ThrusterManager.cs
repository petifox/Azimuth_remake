using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class ThrusterManager : MonoBehaviour
{
    public ParticleSystem Up, Right, Down, Left;
    public float MaxEmittion = 20;

    void Update()
    {
        //UP
        var yourParticleEmission = Up.emission;
        yourParticleEmission.rateOverTime = Mathf.Lerp(0, MaxEmittion, Mathf.Abs(Mathf.Min(0, MasterInput.MovementVector.y)));

        //RIGHT
        yourParticleEmission = Right.emission;
        yourParticleEmission.rateOverTime = Mathf.Lerp(0, MaxEmittion, Mathf.Abs(Mathf.Min(0, MasterInput.MovementVector.x)));

        //DOWN
        yourParticleEmission = Down.emission;
        yourParticleEmission.rateOverTime = Mathf.Lerp(0, MaxEmittion, Mathf.Max(0, MasterInput.MovementVector.y));

        //LEFT
        yourParticleEmission = Left.emission;
        yourParticleEmission.rateOverTime = Mathf.Lerp(0, MaxEmittion, Mathf.Max(0, MasterInput.MovementVector.x));
    }
}
