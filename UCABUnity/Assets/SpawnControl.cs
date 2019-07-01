using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{

    [SerializeField]
    float a, b;

    public Transform[] spawnPoints;
    public GameObject[] zombies;
    int randomSpawnPoint, randomZombies;
    public static bool spawnAllowed;

    // Start is called before the first frame update
    void Start()
    {
        spawnAllowed = true;
        InvokeRepeating("SpawnAMonster", a,b);
    }

    void SpawnAMonster()
    {
        if (spawnAllowed)
        {
            randomSpawnPoint = Random.Range(0, spawnPoints.Length);
            randomZombies = Random.Range(0, zombies.Length);
            Instantiate(zombies[randomZombies], spawnPoints[randomSpawnPoint].position, Quaternion.identity);
        }
    }
}
