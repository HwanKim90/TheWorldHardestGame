using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KJ_spawnPoint : MonoBehaviour
{
    public GameObject Coin1;
    public GameObject Player;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public static bool isFinish;

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
        

        if (col.transform.tag == "SaveZone")
        {
            isFinish = true;
            spawnPoint1 = spawnPoint2;
        }
        if (col.transform.tag == "Enemy")
        {
            transform.position = spawnPoint1.transform.position;
            Coin1.SetActive(true);
            KJ_Coin.countCoin = 0;
            print("????0??");
            

        }
    }
}
    

