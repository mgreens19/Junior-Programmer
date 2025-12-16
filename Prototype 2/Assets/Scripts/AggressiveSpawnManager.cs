using UnityEngine;

public class AggressiveSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeZUpper = 16.0f;
    private float spawnRangeZLower = 1.0f;
    private float spawnPosX;
    private float startDelay = 2;
    private float spawnInterval = 0.5f;
    private Quaternion chosenRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Begin's spawning animals after the start delay at the pace of the interval
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {

        Quaternion rotationRight = Quaternion.Euler(0, 90, 0);

        Quaternion rotationLeft = Quaternion.Euler(0, -90, 0);

       

        if (Random.value < 0.5f)
        {
            spawnPosX = -20f;
            chosenRotation = rotationRight;
        }
        else 
        {
            spawnPosX = 20f;
            chosenRotation = rotationLeft;
        }


            // Returns random int between 0-1
            int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Returns a random z position between -20 and 20 at a x position of 20
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZLower, spawnRangeZUpper));



        // Creates an animal with the corresponding array int that is returned at a random position
        Instantiate(animalPrefabs[animalIndex], spawnPos, chosenRotation);
    }
}
