using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
   
    
        private void OnTriggerEnter(Collider other)
    {
   

        //자기자신 오브젝트만 파괴
        Destroy(gameObject);
    }
   
}
