using UnityEngine;

public class GameOver : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // When the object's collider, collides another object's collider the debug log declares "Game Over!"
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Game Over!");
    }
}
