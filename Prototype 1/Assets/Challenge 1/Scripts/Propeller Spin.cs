using UnityEngine;

public class PropellerSpin : MonoBehaviour
{
    public GameObject propeller;
    public float propellerspeed = 1.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * propellerspeed);
    }
}
