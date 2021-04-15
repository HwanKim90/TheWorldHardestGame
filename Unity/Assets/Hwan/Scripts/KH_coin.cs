using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KH_coin : MonoBehaviour
{
    public Transform player;
    public Transform spawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        print("ºÎµúÈû");
        gameObject.SetActive(false);
    }
    
    
    

        
        

        


    
}
