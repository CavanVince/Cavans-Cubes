using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public int playerLives;

    public void StartGame()
    {
        SceneManager.LoadScene("Mini Game");
        PlayerPrefs.SetInt("PlayerCurrentLives", playerLives);
    }
    public void Quit()
    {
        Application.Quit();
    }
}
