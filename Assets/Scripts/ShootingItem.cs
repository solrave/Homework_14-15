using UnityEngine;

public class ShootingItem : UsableItem
{
    protected override void Use(GameObject user)
    {
       user.GetComponent<ProjectileShooter>().Shoot();
    }
}
