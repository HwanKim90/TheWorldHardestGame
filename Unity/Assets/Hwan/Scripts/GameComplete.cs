using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameComplete : MonoBehaviour
{
    public EndGame endGame;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && CoinManager.coinCntLv10 == 3)
        {
            SceneManager.LoadScene("EndingScene");
            endGame.Gameset();

        }
    }
}
