using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int lives = 10;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Canvas>().enabled = true;
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Level 1");
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
        PlayerPrefs.SetInt("lives", 10);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void LevelSelect()
    {
        SceneManager.LoadScene("Level Select");
        GetComponent<Canvas>().enabled = false;
    }
}
