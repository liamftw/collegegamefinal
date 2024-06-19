using System.Collections;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject playerBullet;
    private bool canShoot = true;
    public AudioSource source;
    public AudioClip clip;

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

        // plays the shoot sound effect
        if (source != null && clip != null)
        {
            source.PlayOneShot(clip);
        }

        canShoot = false;
        yield return new WaitForSeconds(0.12f);
        canShoot = true;
    }

    // bullet instaniater
    void Shoot()
    {
        Instantiate(playerBullet, firePoint.position, firePoint.rotation);
    }
}