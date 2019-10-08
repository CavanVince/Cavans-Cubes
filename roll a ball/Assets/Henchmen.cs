using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Henchmen : MonoBehaviour {

    private LifeManager lifeSystem;

    // Use this for initialization
    void Start()
    {
        lifeSystem = FindObjectOfType<LifeManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            lifeSystem.TakeLife();
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level 10");
        }
        if (other.gameObject.CompareTag("Barrier"))
        {
            Destroy(other);
        }
        if (other.gameObject.CompareTag("JumpBoost"))
        {
            Destroy(other);
        }
     
    }
}
