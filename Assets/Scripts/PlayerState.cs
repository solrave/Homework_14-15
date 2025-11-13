using System;
using DefaultNamespace;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
  private const string HealthStatName = "Health";
   private const string SpeedStatName = "Speed";
   private const float HealthBaseValue = 100f;
   private const float SpeedBaseValue = 10f;

   private PlayerStat _health;
   private PlayerStat _speed;

   public float PlayerSpeed => _speed.CurrentValue;
   
   private void Start()
   {
      Initialize();
   }

   private void Initialize()
   {
      _health = new PlayerHealth(HealthStatName, HealthBaseValue);
      _speed = new PlayerSpeed(SpeedStatName, SpeedBaseValue);
   }
   
   public void AddHealth(float value)
   {
      _health.ModifyState(value);
   }
   
   public void AddSpeed(float value)
   {
      _speed.ModifyState(value);
   }
   
}
