using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TouchWin : MonoBehaviour
{
    public int Score;
    public Text scoreText;

    void Start()
    {
        scoreText.text = "Coins: " + Score;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plus")
        {
            Score++;
            scoreText.text = "Coins: " + Score;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "Win")
        {
            if (Score >= 10)
            {
                SceneManager.LoadScene("Win");
            }
        }

    }
}