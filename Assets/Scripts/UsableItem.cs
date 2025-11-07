using UnityEngine;

public abstract class UsableItem : MonoBehaviour
{
  private readonly string _name;

  protected UsableItem(string name)
  {
    _name = name;
  }
  //
  public string Name => _name;
  
  public abstract void Use();
}