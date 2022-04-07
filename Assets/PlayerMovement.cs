using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody player;
    int movementSpeed = 5;
    int rotationSpeed = 60;
    private Vector3 rotation;

    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //player.velocity = new Vector3(player.velocity.x, player.velocity.y, verticalInput * movementSpeed);

        if (Input.GetKey(KeyCode.A)) rotation = Vector3.down;
        else if (Input.GetKey(KeyCode.D)) rotation = Vector3.up;
        else rotation = Vector3.zero;

        transform.Rotate(rotation * rotationSpeed * Time.deltaTime);

        Vector3 input = new Vector3(0, 0, verticalInput);
        Vector3 dir = input.normalized;
        Vector3 vel = dir * movementSpeed * Time.deltaTime;

        transform.Translate(vel);

    }
}
