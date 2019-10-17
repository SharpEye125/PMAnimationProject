using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ScoreCounter : MonoBehaviour
{
    public int Score = 0;
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Plus")
        {
            Score++;
            Destroy(collision.gameObject);
            if (Score >= 10)
            {
                SceneManager.LoadScene("Win");
            }
        }
        else if (collision.gameObject.tag == "Minus")
        {
            Score--;
            Destroy(collision.gameObject);
            if (Score <= -10)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
    
}
