  using System;
  using UnityEngine;

  public class Projectile : MonoBehaviour
  {
    private Transform _spawnPoint;
    private Rigidbody _rigidbody;

    private void Awake()
    {
      _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
      CheckDistance();
    }

    public void SetSpawnPoint(Transform point)
    {
      _spawnPoint = point;
    }

    private void CheckDistance()
    {
      if ((_spawnPoint.transform.position - transform.position).magnitude > 15f)
      {
        Destroy(gameObject);
      }
    }

    public void Launch(Vector3 direction, float force)
    {
      _rigidbody.AddForce(direction * force, ForceMode.VelocityChange);
    }
  }
