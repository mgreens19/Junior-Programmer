using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public KeyCode SwitchKey;
    private Vector3 ThirdPersonOffset = new Vector3(0, 6, -15);
    private Vector3 FirstPersonOffset = new Vector3(0, 4.43f, 0);
    private bool isFirstPerson;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isFirstPerson = false;

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Input.GetKeyDown(SwitchKey))
        {
            isFirstPerson = !isFirstPerson;
        }

        if (isFirstPerson == false)
        {
            //Camera is set to the players position at an offset in the Third Person
            transform.position = player.transform.position + ThirdPersonOffset;
        }

        else
        {
            //Camera is set to the players position at an offset in the First Person
            transform.position = player.transform.position + FirstPersonOffset;
            transform.rotation = player.transform.rotation;
        }

    }
}

