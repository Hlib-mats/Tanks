using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    int movementSpeed = 5;
    int rotationSpeed = 60;
    private Vector3 rotation;

    private void Update()
    {
        Vector3 input = new Vector3(0, 0, 1);
        Vector3 dir = input.normalized;
        Vector3 vel = dir * movementSpeed * Time.deltaTime;

        transform.Translate(vel);
    }
}
