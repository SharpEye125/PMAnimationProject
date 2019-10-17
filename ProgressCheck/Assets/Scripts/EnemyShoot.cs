using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform player;
    public float bulletSpeed = 5.0f;
    public GameObject prefab;
    public float bulletLifetime = 1.0f;
    public float shootDelay = 1.0f;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > shootDelay)
        {
            Vector2 shootDir = new Vector2(player.position.x - transform.position.x,
                player.position.y - transform.position.y);
            timer = 0;
            if (shootDir.magnitude <= 15 )
            {
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletSpeed;
            Destroy(bullet, bulletLifetime);
            }
        }

    }
}
