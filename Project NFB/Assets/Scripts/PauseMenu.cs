using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPauseing()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);

    }

    public void OnResuming()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void OnRestarting()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
