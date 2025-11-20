using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3 (19.46f, 1.61f, -0.48f);

    // Start is called before the first frame update
    void Start()
    { 

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Camera is teleported to planes position at an offset
        transform.position = plane.transform.position + offset;
    }
}
