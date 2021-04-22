using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene1 : MonoBehaviour
{
    public GameObject coin;
    private void OnTriggerEnter(Collider other)
    {
        
      
        
        if (other.transform.tag == "Player" && KJ_Coin.countCoin == 3)
        {
            print("KJ_Coin.countCoin");
            SceneManager.LoadScene(4);
        }
    }
}
