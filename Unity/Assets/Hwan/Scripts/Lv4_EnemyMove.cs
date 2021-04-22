using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv4_EnemyMove : MonoBehaviour
{

    public float speed = 5;
    
    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 180 * Time.deltaTime * speed);
    }

    
}
