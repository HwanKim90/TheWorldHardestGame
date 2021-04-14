using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{

    public GameObject spawnPoint1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "Enemy")
        {
            print("Ãæµ¹!!");
            this.transform.position = spawnPoint1.transform.position;
        }
    }
}
