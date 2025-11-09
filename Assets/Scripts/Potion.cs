using System;
using UnityEngine;

public abstract class Potion : UsableItem
{
  [SerializeField] private float _effectValue;
  

  protected float EffectValue => _effectValue;
  
}
