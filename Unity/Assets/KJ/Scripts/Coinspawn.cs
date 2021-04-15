using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinspawn : MonoBehaviour
{
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
        if (Player.transform.position == spawnPoint1.transform.position)
        {


            gameObject.SetActive(true);


        }
        else
        {
            gameObject.SetActive(false);
        }
    }

}

