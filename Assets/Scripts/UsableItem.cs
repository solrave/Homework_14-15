using System;
using UnityEngine;

public abstract class UsableItem : MonoBehaviour
{
  [SerializeField] private string _name;
  [SerializeField] private ParticleSystem _itemParticle;
  [SerializeField] protected Rigidbody _itemRigidbody;
  public string Name => _name;
  
  private void Start()
  {
    _itemRigidbody.isKinematic = true;
  }

  public void UseItem(GameObject user)
  {
    Use(user);
    Instantiate(_itemParticle, transform.position, Quaternion.identity).Play();
  }

  protected abstract void Use(GameObject user);

  public virtual void Throw(PlayerState user)
  {
    transform.SetParent(null);
    _itemRigidbody.isKinematic = false;
    _itemRigidbody.GetComponent<Collider>().isTrigger = false;
    _itemRigidbody.AddForce(user.transform.forward * 5,ForceMode.Impulse);
  }
  // protected virtual void Discard(){}
  
}

