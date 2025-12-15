using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    public float speed = 10.0f;
    private float xRange = 20.0f;
    private float zRangeUpper = 16.0f;
    private float zRangeLower = 1.0f;
    private float verticalInput;

    public GameObject projectilePrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MapLimit();
        PlayerMovement();
        FoodFire();
    }

    // Player Movement forward, backwards, & left to right with WASD or Arrow Keys
    void PlayerMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

    }

    // Fires a piece of food upon pressing space
    void FoodFire()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

    }

    // Players may not go past this point
    void MapLimit()
    {

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -zRangeLower)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zRangeLower);
        }

        if (transform.position.z > zRangeUpper)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRangeUpper);
        }
    }
}
