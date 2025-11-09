using UnityEngine;

public class HealPotion : Potion
{
    protected override void Use(PlayerState user)
    {
        user.AddHealth(EffectValue);
        base.Use(user);
    }
    
}
