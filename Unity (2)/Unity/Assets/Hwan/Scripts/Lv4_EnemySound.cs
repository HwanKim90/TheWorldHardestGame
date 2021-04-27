using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv4_EnemySound : MonoBehaviour
{
    public AudioSource audio1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            audio1.GetComponent<AudioSource>().Play();
            

        }
    }
}
