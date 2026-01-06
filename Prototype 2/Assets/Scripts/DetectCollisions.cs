using UnityEngine;

public class DetectCollisions : MonoBehaviour

{
   
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
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
        }


        if (other.CompareTag("Player"))
        {
            GameManager.LoseLife();
        }



    }
}
