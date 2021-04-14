using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    //충돌했을 때 부딪힌 오브젝트 모두 파괴(Trigger를 체크했기 때문에 Oncollision으로 
    //하지 않고 Ontrigger로 한다.
    {
        //부딪힌 오브젝트만 파괴
        Destroy(gameObject);
    }
}
