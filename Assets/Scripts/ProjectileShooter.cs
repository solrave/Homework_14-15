using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    [SerializeField] private Projectile _projectilePrefab;
    [SerializeField] private Transform _spawnPoint;

    public void Shoot()
    {
        Projectile bullet = Instantiate(_projectilePrefab, _spawnPoint);
        bullet.SetSpawnPoint(_spawnPoint);
        bullet.Launch(_spawnPoint.forward, 15f);
    }
}
