using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv10_EnemyPatrol : MonoBehaviour
{
    float moveSpeed = 2;
    public bool moveUp;
    
    void Update()
    {
        if (moveUp)
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }    
        else
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wall"))
        {
           moveUp = !moveUp;
            
        }
    }
}

    

