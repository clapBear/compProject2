using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollision : MonoBehaviour
{
  [Header("Unity Setup")]
  public ParticleSystem deathParticle;

  void OnDestroy()
  {
        Instantiate(deathParticle, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
  }
}
