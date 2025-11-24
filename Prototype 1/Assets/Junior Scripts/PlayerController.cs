using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Determines player using the script
    public string inputID;

    //Private Variables
    private float speed = 15.0f;
    private float rotateSpeed = 45.0f;
    private float horizontalInput;
    private float verticalInput;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Gets Player Input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        verticalInput = Input.GetAxis("Vertical" + inputID);

        // Moves vehicle forward based on Player Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * horizontalInput);
    }
}
