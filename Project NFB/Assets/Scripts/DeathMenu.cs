using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    TouchControl touchControl;
    [SerializeField] GameObject deathMenu;
    // Start is called before the first frame update
    void Start()
    {
        touchControl = FindObjectOfType<TouchControl>();
    }

    // Update is called once per frame
    void Update()
    {
        if(touchControl.isDead == true)
        {
            Invoke("ActivateDeathMenu", 1f);
        }


    }

    private void ActivateDeathMenu()
    {
        deathMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
