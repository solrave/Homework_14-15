using System;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
   [SerializeField] private List<Transform> _spawnPoints;
   [SerializeField] private List<UsableItem> _itemsPrefabs;
   [SerializeField] private float _spawnCooldown;
   private float _elapsedTime;
   [SerializeField] private UnityEngine.GameObject _potion;

   private void Start()
   {
 
   }
}
