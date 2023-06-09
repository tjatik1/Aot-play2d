using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grounds : MonoBehaviour
{
    [SerializeField] private GameObject[] templatePlatforms;

    private GameObject spawnPlatforms;


    private void Start()
    {
        InvokeRepeating("Platforms", 2, 2.6f);
    }

    
    private void Platforms()
    {
        Instantiate (templatePlatforms[Random.Range(0, templatePlatforms.Length)], transform.position, Quaternion.identity);
    }
}
