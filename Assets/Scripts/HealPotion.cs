using UnityEngine;

public class HealPotion : Potion
{
    protected override void Use(GameObject user)
    {
        user.GetComponent<PlayerState>().AddHealth(EffectValue);
    }
    
}
