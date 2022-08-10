using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaxValentine
{
    public class CharacterSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject playerPrefab;
        [SerializeField] private Transform playerSpawnPoint;
        void Start()
        {
            // What do we need to spawn our player character when the game starts
            //What do we need?
            // - make a player character prefab
            // - make a reference to that prefab (a variable)
            // - spawn it ("Instantiate")
            Instantiate(playerPrefab, playerSpawnPoint.position, Quaternion.identity);
        }
    }
}
