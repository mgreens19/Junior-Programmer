using UnityEngine;

public class DetectCollisions : MonoBehaviour

{
    private static int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // When the object's collider, collides another object's collider, and the other object has the "Food" tag both objects are destroyed
    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Food"))
        {
            // Score is increased when an animal is destroyed
            score++;
            Debug.Log(score);

            // Animal and food are destroyed
            Destroy(gameObject);
            Destroy(other.gameObject);
            
        }

      

    }
}
