using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject[] animalPrefabs;
  public GameObject[] aggressiveAnimalPrefabs;
  private float spawnRangeX = 10;
  private float spawnRangeZ = 7;
  private float startDelay = 2;
  private float spawnInterval = 1.5f;

  // Start is called before the first frame update
  void Start()
  {
    InvokeRepeating("SpawnRandomAnimal", startDelay, 1.5f);
    InvokeRepeating("SpawnRandomAggressiveAnimal", 10, 4);
  }

  // Update is called once per frame
  void Update()
  {
  }

  void SpawnRandomAnimal()
  {
    int animalIndex = Random.Range(0, animalPrefabs.Length);
    Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, 20);
    Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
  }

  void SpawnRandomAggressiveAnimal()
  {
    int animalIndex = Random.Range(0, aggressiveAnimalPrefabs.Length);
    bool isLeft = Random.value >= 0.5;
    float posX = isLeft ? -spawnRangeX - 5 : spawnRangeX + 5;
    Vector3 spawnPos = new Vector3(posX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
    Quaternion rotation = Quaternion.Euler(new Vector3(0, isLeft ? 90 : -90, 0));
    GameObject animal = Instantiate(aggressiveAnimalPrefabs[animalIndex], spawnPos, rotation);
  }
}
