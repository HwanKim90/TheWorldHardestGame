using UnityEngine;

public class CoinManager : MonoBehaviour
{
    
    public static int coinCntLv10 = 0;
    public GameObject[] coins;

    private void Start()
    {
        
    }

    void Update()
    {
        if (Player_State_LV10.isFly)
        {
            for (int i = 0; i < coins.Length; i++)
            {
                coins[i].SetActive(true);
                coinCntLv10 = 0;
                print("���ΰ��� : " + coinCntLv10);
            }
        }
    }
}



















        
        
        


