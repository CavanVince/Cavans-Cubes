using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Celebration : MonoBehaviour {
    private GameObject Music;

	// Use this for initialization
	void Start () {
        Music = GameObject.FindGameObjectWithTag("Music");
        Destroy(Music);
    }
public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }	

}
