using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KJ_spawnPoint : MonoBehaviour
{
    public GameObject Coin1;
    public GameObject Player;
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
            transform.position = spawnPoint1.transform.position;
            Coin1.SetActive(true);
            Coin.count = 0;
            print("����0��");
            

        }
    }
}
    

