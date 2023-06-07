using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backs : MonoBehaviour
{
    private GameObject spawnBackground;

    [SerializeField] private int TimeSpawn = 1;

    [SerializeField] private float SpawnRate = 10f;

    [SerializeField] private GameObject templateBackground;

    private void Start()
    {
        InvokeRepeating("Background", TimeSpawn , SpawnRate);
    }

    private void Background()
    {
        spawnBackground = Instantiate(templateBackground, transform.position, Quaternion.identity) as GameObject;
    }
}
