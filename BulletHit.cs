using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Subtract HP and add a bullet explosion
        if (collision.tag == "wall")
        {
            Destroy(gameObject);
        }
        else if(collision.tag == "enemy")
        {
            Debug.Log("Enemy Hit!");
            Destroy(gameObject);
        }
    }
}

