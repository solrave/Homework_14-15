using UnityEngine;

public class ProjectileShooter : MonoBehaviour
{
    [SerializeField] private GameObject _projectilePrefab;
    [SerializeField] private Transform _spawnPoint;

    public void Shoot()
    {
        var bullet = Instantiate(_projectilePrefab, _spawnPoint);
        bullet.GetComponent<Projectile>().SetSpawnPoint(_spawnPoint);
        bullet.GetComponent<Rigidbody>().AddForce(_spawnPoint.forward * 5f);
    }
}
