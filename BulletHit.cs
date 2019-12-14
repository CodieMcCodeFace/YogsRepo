using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{
    public GameObject bulletEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Subtract HP and add a bullet explosion
        if (collision.tag == "wall")
        {
            GameObject wallHit = Instantiate(bulletEffect, gameObject.transform.position, Quaternion.identity);

            Destroy(wallHit, 0.5f);
            Destroy(gameObject);
        }
        else if(collision.tag == "enemy")
        {
            Debug.Log("Enemy Hit!");
            GameObject effect = Instantiate(bulletEffect,transform.position, Quaternion.identity);

            Destroy(effect, 0.5f);
            Destroy(gameObject);
        }
    }
}

