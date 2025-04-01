using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] animalPrefabsLeft;
    public GameObject[] animalPrefabsRight;

    public float Leftspawn = -28;
    public float Rightspawn = 28;

    private float spawnRangeX = 20;
    private float spawnPosZ = 25;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
   
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay + 1, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay + 1, spawnInterval);
    }

    // Update is called once per frame
    void SpawnRandomAnimal()
    {
            //Randomly generate aniamlm index and spawn position
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalLeft()
    {
            //Randomly generate aniamlm index and spawn position
            int animalIndex = Random.Range(0, animalPrefabsLeft.Length);
            Vector3 spawnPos = new Vector3(Leftspawn, 0, Random.Range(0, 15));
            Instantiate(animalPrefabsLeft[animalIndex], spawnPos, animalPrefabsLeft[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalRight()
    {
            //Randomly generate aniamlm index and spawn position
            int animalIndex = Random.Range(0, animalPrefabsRight.Length);
            Vector3 spawnPos = new Vector3(Rightspawn, 0, Random.Range(0, 15));
            Instantiate(animalPrefabsRight[animalIndex], spawnPos, animalPrefabsRight[animalIndex].transform.rotation);
    }
}
