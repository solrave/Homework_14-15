
public class SpeedUpPotion : Potion
{
  protected override void Use(PlayerState user)
  {
    user.AddSpeed(EffectValue);
    base.Use(user);
  }
}
