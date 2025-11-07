using UnityEngine;

public abstract class Potion : UsableItem
{
  private float _effectValue;

  protected Potion(string name, float effectValue) : base(name)
  {
    _effectValue = effectValue;
  }

  public float EffectValue => _effectValue;
  
  
}
