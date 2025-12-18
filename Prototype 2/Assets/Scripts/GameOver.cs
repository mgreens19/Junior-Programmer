using JetBrains.Annotations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int lives = 3;
    private static int score = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("lives: " + lives);
        Debug.Log("score: " + score);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    // Method that makes player lose lives and declares it
     public static void LoseLife()
    {
        if (lives > 0)
        {
            lives--;
            Debug.Log("lives: " + lives);
        }

        else 
        {
            Debug.Log("Game Over!");
        }

    }

    public static void Feed()
    {
        score++;
        Debug.Log("score: " + score);
    }
}
