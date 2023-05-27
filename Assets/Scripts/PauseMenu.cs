using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject buttonPause;
    [SerializeField] private GameObject pauseMenu;
    public void Pause()
    {
        Time.timeScale = 0f;
        buttonPause.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void Quit()
    {
        Time.timeScale = 1f;
        buttonPause.SetActive(true);
        pauseMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
