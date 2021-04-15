using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KH_playerMove : MonoBehaviour
{
  
    int count = 0;

    public float speed = 5;

   
     void Start()
    {
        
    }
    void Update()
    {        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 dirV = Vector3.up * v;
        Vector3 dirH = Vector3.right * h;

        Vector3 dir = dirV + dirH;
        

        transform.position += dir * speed * Time.deltaTime;

    }
    private void OnTriggerEnter(Collider other)
    {
        count++;
        print("코인추가");
    }
}

