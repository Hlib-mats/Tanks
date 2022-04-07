using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    

    // Update is called once per frame
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.GetComponent<EnemyMovement>() != null)
        {
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
    }
}
