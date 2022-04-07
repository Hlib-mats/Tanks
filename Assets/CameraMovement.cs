using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    int rotationSpeed = 30;
    public GameObject GameObject;

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;

        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(gameObject.transform.position, new Vector3(0, -1, 0), rotationSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(gameObject.transform.position, new Vector3(0, 1, 0), rotationSpeed * Time.deltaTime);
        }
    }
}
