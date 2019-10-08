using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform respawnPoint;
    private LifeManager lifeSystem;
   
    private void Start()
    {
        lifeSystem = FindObjectOfType<LifeManager>();    
    }

    private void OnTriggerEnter(Collider other)
    {
        Player.transform.position = respawnPoint.transform.position;
        lifeSystem.TakeLife();
       
    }

}
