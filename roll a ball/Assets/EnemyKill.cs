using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKill : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
    private LifeManager lifeSystem;

    void Start()
    {
        lifeSystem = FindObjectOfType<LifeManager>();
    }

     void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
        lifeSystem.TakeLife();
    }

}

