using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseDetection : MonoBehaviour {

    public Transform PauseMenu;
    private GameObject Music;

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
	}
    public void Pause()
    {
        if (PauseMenu.gameObject.activeInHierarchy == false)
        {
            PauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            PauseMenu.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void MainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1;
        Music = GameObject.FindGameObjectWithTag("Music");
        Destroy(Music);
    }
   public void EndGame()
    {
        Application.Quit();
    }
}
