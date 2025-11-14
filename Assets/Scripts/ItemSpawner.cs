using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ItemSpawner : MonoBehaviour
{
   [SerializeField] private List<Transform> _spawnPoints;
   [SerializeField] private List<UsableItem> _itemsPrefabs;
   [SerializeField] private float _spawnCooldown;
   private Timer _timer;

   private void Start()
   {
      _timer = new Timer(_spawnCooldown);
   }

   private void Update()
   {
      if (_timer.Run())
      {
         SpawnItem();
      }
   }

   private void SpawnItem()
   {
      Instantiate(_itemsPrefabs[Random.Range(0, _itemsPrefabs.Count)], _spawnPoints[Random.Range(0, _spawnPoints.Count)]);
   }
}