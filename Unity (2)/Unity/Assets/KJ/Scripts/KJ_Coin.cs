using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KJ_Coin : MonoBehaviour
{
    public float speed = 5;
    public static int countCoin;
    public GameObject CoinSound;

    private void Update()
    {
        transform.Rotate(new Vector3(1, 0, 0) * 180 * Time.deltaTime * speed);
    }

    void OnTriggerEnter(Collider col)
    {
        AudioSource audio = CoinSound.GetComponent<AudioSource>();
        audio.Play();

        countCoin++;
        print("ÄÚÀÎ " + countCoin);
        gameObject.SetActive(false);


       
    }
    
}





