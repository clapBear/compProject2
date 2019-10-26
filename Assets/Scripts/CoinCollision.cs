using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
  [Header("Unity Setup")]
  public ParticleSystem deathParticle;
    
    void OnTriggerEnter()
    {
        Instantiate(deathParticle, transform.position, Quaternion.identity);
    }
}
