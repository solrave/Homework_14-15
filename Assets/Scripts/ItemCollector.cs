using System;
using UnityEngine;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private PlayerState _playerState;
    [SerializeField] private Transform _itemPlaceholder;
    
    private UsableItem _currentItem;
    public bool HoldingItem => _currentItem != null;
    public UsableItem CurrenItem => _currentItem;
    public PlayerState PlayerState => _playerState;
    
    private void Start()
    {
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (HoldingItem)
            return;
        
        if (other.TryGetComponent(out UsableItem item))
        {
            item.transform.SetParent(transform);
            item.transform.position = _itemPlaceholder.position;
            _currentItem = item;
        }
    }

    public void ReleaseItemAndDestroy()
    {
        Destroy(_currentItem.gameObject);
        _currentItem = null;
    }
    
    public void ReleaseItem()
    {
        _currentItem = null;
    }
}

