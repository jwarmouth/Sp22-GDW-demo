using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JackSpawner : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] spawnLocations;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPrefab", 1.0f, 0.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnPrefab();
        }
    }

    void SpawnPrefab()
    { 
        int dieRoll = Random.Range(0, prefabs.Length);
        int randomLoc = Random.Range(0, spawnLocations.Length);
        Instantiate(
            prefabs[dieRoll], 
            spawnLocations[randomLoc].position, 
            prefabs[dieRoll].transform.rotation
            );
    }

}
