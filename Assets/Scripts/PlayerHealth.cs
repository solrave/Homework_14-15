  using UnityEngine;

  public class PlayerHealth : PlayerStat
  {
    public PlayerHealth(string name, float baseValue) : base(name, baseValue)
    {
    }

    public override void ModifyState(float value)
    {
      if (value < 0)
      {
        Debug.Log("Error. Potion effect value can't be negative!");
        return;
      }
      
      if (CurrentValue == BaseValue)
      {
        Debug.Log("You are fully healed all ready. Nothing happened.");
        return;
      }
      
      if (CurrentValue < BaseValue)
      {
        CurrentValue += value;
        if (CurrentValue > BaseValue)
          CurrentValue = BaseValue;
        Debug.Log($"Potion restored your {Name} by {value} points.");
      }
    }
  }
