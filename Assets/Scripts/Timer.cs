using UnityEngine;

public class Timer
{
  private float _elapsedTime;
  private readonly float _maxTime;

  public Timer(float maxTime)
  {
    _maxTime = maxTime;
  }

  public bool Run()
  {
    _elapsedTime += Time.deltaTime;
      
    if (_elapsedTime >= _maxTime)
    {
      ResetTimer();
      return true;
    }
    return false;
  }

  private void ResetTimer()
  {
    _elapsedTime = 0f;
  }
}