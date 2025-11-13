  using UnityEngine;

  public class Projectile : MonoBehaviour
  {
    private Transform _spawnPoint;
    private Rigidbody _rigidbody;

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
  }
