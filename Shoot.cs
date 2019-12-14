using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{

    public GameObject prefab;
    public Transform firePoint;
    public float bulletSpeed = 15f;
    public float shotgunBulletSpeed = 15.0f;
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
    
    void shotgunShot()
    {

        GameObject shotgun = Instantiate(prefab, firePoint.position, Quaternion.identity);

        Vector3 shotgunPos = new Vector3(0, 0.5f, 0);
        Vector3 shotgunPos2 = new Vector3(0f, 0.5f, 0f);

        GameObject shot2 = Instantiate(prefab, firePoint.position + shotgunPos, Quaternion.identity);
        GameObject shot3 = Instantiate(prefab, firePoint.position - shotgunPos, Quaternion.identity);

        Rigidbody2D shotgunPhysics = shotgun.GetComponent<Rigidbody2D>();
        Rigidbody2D shot2Phys = shot2.GetComponent<Rigidbody2D>();
        Rigidbody2D shot3Phys = shot3.GetComponent<Rigidbody2D>();

        shot2Phys.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
        shot3Phys.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
        shotgunPhysics.AddForce(firePoint.up * bulletSpeed, ForceMode2D.Impulse);
    }
}
