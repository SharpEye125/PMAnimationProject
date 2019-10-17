using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class CrudeDoorScript : MonoBehaviour
{
    int Score;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Door")
        {
            if (Score >= 9)
            {
                Destroy(collision.collider);

            }
            
        }
    }
}
