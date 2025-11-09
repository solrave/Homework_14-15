using UnityEngine;

public abstract class PlayerStat
{
   private string _name;
   private readonly float _baseValue;
   
   protected PlayerStat(string name, float baseValue)
   {
      _name = name;
      _baseValue = baseValue;
      CurrentValue = _baseValue;
   }
  
   public string Name => _name;
   public float BaseValue => _baseValue;
   public float CurrentValue { get; protected set; }

   public abstract void ModifyState(float value);
}
