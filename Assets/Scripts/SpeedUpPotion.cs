using UnityEngine;

public class SpeedUpPotion : Potion
{
  protected override void Use(GameObject user)
  {
    user.GetComponent<PlayerState>().AddSpeed(EffectValue);
  }
}
