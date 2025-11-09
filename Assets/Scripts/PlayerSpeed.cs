using UnityEngine;

namespace DefaultNamespace
{
  public class PlayerSpeed : PlayerStat
  {
    public PlayerSpeed(string name, float baseValue) : base(name, baseValue)
    {
    }

    public override void ModifyState(float value)
    {
      if (value < 0)
      {
        Debug.Log("Error. Potion effect value can't be negative!");
        return;
      }
      
      CurrentValue += value;
      Debug.Log($"Potion increased your {Name} by {value} points.");
    }
  }
}