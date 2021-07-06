using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] int maxHitPoints = 5;
    
    int currentHitPoints = 0;
    void Start()
    {
        currentHitPoints = maxHitPoints;
    }

    void OnParticleCollision(GameObject other)
    {
        ProcessHit();
    }

    void ProcessHit()
    {
        Debug.Log("ProcessingHit");
        currentHitPoints--;
        if (currentHitPoints < 1)
        {
            Destroy(gameObject);
        }
    }


    
}
