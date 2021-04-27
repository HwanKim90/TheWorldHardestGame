using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRot : MonoBehaviour
{
    public Transform player;   

    void Update()
    {
        transform.Rotate(new Vector3(0, 1, 0) * 180 * Time.deltaTime, Space.World);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FalseCoin();
            SoundManager.instance.PlayEFT(SoundManager.EFT_TYPE.COIN);
        }
    }
    void FalseCoin()
    {
        CoinManager.coinCntLv10++;
        gameObject.SetActive(false);
        print("ÄÚÀÎ°¹¼ö : " + CoinManager.coinCntLv10);
       
    }
    
}
            
        






