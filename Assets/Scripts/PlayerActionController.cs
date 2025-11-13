using System;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{
   [SerializeField] private ItemCollector _itemCollector;
   [SerializeField] private PlayerState _playerState;
   [SerializeField] private ProjectileShooter _shooter;
   
   private InputReader _inputReader;
   private float _elapsedTime = 0f;
   private readonly float _destroyTime = 2f;
   private UsableItem _itemToDestroy;

   private void Start()
   {
      _inputReader = new InputReader();
   }

   private void Update()
   {
      MovePlayer();
      UseCurrentItem();
      if (_itemToDestroy != null)
      {
         SetDestroyTimer(_itemToDestroy);
      }
   }

   private void MovePlayer()
   {
      transform.Translate(new Vector3(_inputReader.XAxis,0,_inputReader.YAxis) * (_playerState.PlayerSpeed * Time.deltaTime));
   }

   private void UseCurrentItem()
   {
      if (_itemCollector.HoldingItem)
      {
         if (_inputReader.UseActionInvoked)
         {
            _itemCollector.CurrenItem.UseItem(_playerState.gameObject);
            _itemCollector.ReleaseItemAndDestroy();
         }

         if (_inputReader.ThrowActionInvoked)
         {
            _itemCollector.CurrenItem.Throw(_playerState);
            _itemToDestroy = _itemCollector.CurrenItem;
           _itemCollector.ReleaseItem();
         }
      }
   }

   private void SetDestroyTimer(UsableItem item)
   {
      _elapsedTime += Time.deltaTime;
      if (_elapsedTime >= _destroyTime)
      {
         Destroy(item.gameObject);
      }
   }
}
