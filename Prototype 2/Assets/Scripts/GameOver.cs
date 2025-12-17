using UnityEngine;

public class GameOver : MonoBehaviour
{
    private static int lives = 3;
    private float lowerBound = -10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < lowerBound)
        {
            lives--;
            Debug.Log(lives);
            
        }

        if (lives <= 0)
        {
            Debug.Log("Game Over!");
        }

    }

    // When the object collides with a Player, lives go down upon reaching 0 the game is over
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            lives--;
            Debug.Log(lives);
        }

       
    }
}
