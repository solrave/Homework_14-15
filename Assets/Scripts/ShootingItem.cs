using UnityEngine;

public class ShootingItem : UsableItem
{
    protected override void Use(PlayerState user)
    {
       user.Shoot();
    }
}
