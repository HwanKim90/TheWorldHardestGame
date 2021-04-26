using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV10_P1EnemyMove : MonoBehaviour
{
    public Transform[] wayPoint;
    [SerializeField]
    public static float moveSpeed = 7;
    int index = 0;
    float rotY = 1;
    
    void Update()
    {
        index %= wayPoint.Length;
        Vector3 dir = wayPoint[index].position - transform.position;
        transform.Translate(dir.normalized * moveSpeed * Time.deltaTime, Space.World);
        transform.Rotate(new Vector3(0, rotY, 0) * 180 * Time.deltaTime);

        if (dir.magnitude < 0.1f)
        {
            index++;
            rotY *= -1;
        }
        
    }


}
