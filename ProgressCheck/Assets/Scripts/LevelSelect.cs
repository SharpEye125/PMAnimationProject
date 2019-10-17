using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
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
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1;
    }
    public void LoadCastle()
    {
        SceneManager.LoadScene("Level 1");
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    public void LoadSwamp()
    {
        SceneManager.LoadScene("Swamp");
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
    public void LoadTopDown()
    {
        SceneManager.LoadScene("TopDown");
        GetComponent<Canvas>().enabled = false;
        Time.timeScale = 1;
    }
}
