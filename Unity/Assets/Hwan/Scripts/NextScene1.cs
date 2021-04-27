using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene1 : MonoBehaviour
{

    

    private void OnTriggerEnter(Collider other)
    {
        
      
        
        if (other.transform.tag == "Player" && KJ_Coin.countCoin == 3)
        {
            SceneManager.LoadScene("Lv10_MapScene");
        }
    }
}
