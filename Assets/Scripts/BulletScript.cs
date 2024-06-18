using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    enum SpawnerType { Straight, Spin }

    [Header("Bullet Attributes")]
    public GameObject bullet;
    public float bulletLife = 1f;
    public float speed = 1f;

    [Header("Spawner Attributes")]
    [SerializeField] private SpawnerType spawnerType;
    private float initialFiringRate = 0.20f;
    private float minimumFiringRate = 0.06f;
    private float currentFiringRate;

    private GameObject spawnedBullet;
    private float timer = 0f;

    // Start is called before the first frame update
    void Start()
    {
        currentFiringRate = initialFiringRate;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (spawnerType == SpawnerType.Spin)
            transform.eulerAngles = new Vector3(0f, 0f, transform.eulerAngles.z + 1f);

        if (timer >= currentFiringRate)
        {
            Fire();
            timer = 0;
        }

        // firerate increase
        if (currentFiringRate > minimumFiringRate)
        {
            currentFiringRate -= 0.015f * Time.deltaTime;
            currentFiringRate = Mathf.Max(currentFiringRate, minimumFiringRate);
        }
    }

    private void Fire()
    {
        if (bullet)
        {
            spawnedBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            spawnedBullet.GetComponent<Bullet>().speed = speed;
            spawnedBullet.GetComponent<Bullet>().bulletLife = bulletLife;
            spawnedBullet.transform.rotation = transform.rotation;
        }
    }
}
