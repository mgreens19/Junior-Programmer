using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float delay = 1.0f;
    private float nextSpawnTime = 0f;
   

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog with a cooldown afterwards
        if (Input.GetKeyDown(KeyCode.Space) & Time.time >= nextSpawnTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            //creates a future timestamp for when you can spawn the dog again
            nextSpawnTime = Time.time + delay;
            

        }
    }
}
