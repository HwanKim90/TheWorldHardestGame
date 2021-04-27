using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneCG : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (KJ_Coin.countCoin > 0 && KJ_spawnPoint.isFinish)
        {

            if (other.gameObject.tag == "Player")
            {
                SceneManager.LoadScene(2);
              
                
            }
        }
    }
}



