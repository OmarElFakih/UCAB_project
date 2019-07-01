using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombiesspawn2 : MonoBehaviour
{

    public Transform spawnPoints;
    public GameObject zombies;


	public void SpawnAMonster()
 
		{
            Instantiate(zombies, spawnPoints.position, Quaternion.identity);
        }
    
	
}