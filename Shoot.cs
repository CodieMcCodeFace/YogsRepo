using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject prefab;
    public Transform firePoint;
    public float bulletSpeed = 5.0f;
    void Update()
    {
        ShootInput();
    }

    void ShootInput()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            BulletShot();
        }
    }
    void BulletShot()
    {
        GameObject bullet = Instantiate(prefab, firePoint.position, Quaternion.identity);

        Rigidbody2D Rigid = bullet.GetComponent<Rigidbody2D>();

        Rigid.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);

    }
}
