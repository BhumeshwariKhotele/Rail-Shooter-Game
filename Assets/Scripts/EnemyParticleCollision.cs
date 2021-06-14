using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParticleCollision : MonoBehaviour
{
    private void Awake()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = true;
    }
    private void OnParticleCollision(GameObject other)
    {
        Destroy(gameObject);
    }
}
