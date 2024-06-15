using System.Collections;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject playerBullet;
    private bool canShoot = true;

    public void Shooting()
    {
        if (canShoot)
        {
            StartCoroutine(ShootWithDelay());
        }
    }

    IEnumerator ShootWithDelay()
    {
        Shoot();
        canShoot = false;
        yield return new WaitForSeconds(0.1f);
        canShoot = true;
    }

    // The method that actually instantiates the bullet
    void Shoot()
    {
        Instantiate(playerBullet, firePoint.position, firePoint.rotation);
    }
}