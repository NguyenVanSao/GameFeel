using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform BulletSpawnPoint => _bulletSpawnPoint;

    [SerializeField] private Transform _bulletSpawnPoint;
    [SerializeField] private Bullet _bulletPrefab;
    
    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetMouseButtonDown(0)) {
            ShootProjectile();
        }
    }

    private void ShootProjectile()
    {
        Debug.Log("Shoot");
        Bullet newBullet = Instantiate<Bullet>(_bulletPrefab, _bulletSpawnPoint);
    }
}
