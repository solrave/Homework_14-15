  using UnityEngine;

  public class Projectile : MonoBehaviour
  {
    private Transform _spawnPoint;

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
      if ((_spawnPoint.transform.position - transform.position).magnitude > 5f)
      {
        Destroy(gameObject);
      }
    }
  }
