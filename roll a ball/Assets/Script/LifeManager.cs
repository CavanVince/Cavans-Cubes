using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifeManager : MonoBehaviour
{
 
    private int lifeCounter ;
    private Text theText;

    // Use this for initialization
    void Start()
    {
        theText = GetComponent<Text>();
        lifeCounter = PlayerPrefs.GetInt("PlayerCurrentLives");
    }

    // Update is called once per frame
    void Update()
    {
        theText.text = "" + lifeCounter;
        if (lifeCounter <= 0)
            SceneManager.LoadScene("Game Over");
        

    }
    public void TakeLife()
    {
        lifeCounter--;
        PlayerPrefs.SetInt("PlayerCurrentLives", lifeCounter);
    }
}

