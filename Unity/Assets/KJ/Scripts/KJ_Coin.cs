using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KJ_Coin : MonoBehaviour
{
    public static int count;

  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame


    void OnTriggerEnter(Collider col)
    {
        count++;
        print("ÄÚÀÎ " + count);
        gameObject.SetActive(false);
    }
}





