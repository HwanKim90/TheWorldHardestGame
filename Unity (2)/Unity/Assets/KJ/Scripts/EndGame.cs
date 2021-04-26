using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndGame : MonoBehaviour
{
    
    UIManager Timestop;

    // Start is called before the first frame update
    void Start()
    {
        Timestop = GameObject.Find("UIManager").GetComponent<UIManager>();
             
    }

    // Update is called once per frame
 

    public void Gameset()
    {
        SceneManager.LoadScene("EndingScene");
        KJ_Coin.countCoin = 0;
        Timestop.gameStart = false;
    }

}
