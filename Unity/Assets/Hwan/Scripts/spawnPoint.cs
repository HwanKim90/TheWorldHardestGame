using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPoint : MonoBehaviour
{

    public GameObject spawnPoint1;
    public GameObject spawnPoint2;

    

    void OnTriggerEnter(Collider col)
    {
        if (col.transform.tag == "SaveZone")
        {
            print("sz Åë°ú");
            spawnPoint1 = spawnPoint2;
        }
        
        if (col.transform.tag == "Enemy")
        {
            transform.position = spawnPoint1.transform.position;
        }
       


        
    }
}
