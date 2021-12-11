using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initialization1 : MonoBehaviour
{ 
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemy;

    private void Start()
    {
        Invoke(nameof(PlayerInitialization), 1f);
        Invoke(nameof(EnemyInitialization), 3f);
    }
    private void PlayerInitialization()
    {
        Instantiate(player);
    }

    private void EnemyInitialization()
    {
        Instantiate(enemy);
    }
}
