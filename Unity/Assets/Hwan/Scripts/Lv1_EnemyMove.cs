using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1_EnemyMove : MonoBehaviour
{
    public float moveSpeed = 4f;

    public bool moveLeft;

    void Update()
    {
        if (moveLeft)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject)
        {
            moveLeft = !moveLeft;
        }
    }
}
