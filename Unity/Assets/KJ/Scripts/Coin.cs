using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    //�浹���� �� �ε��� ������Ʈ ��� �ı�(Trigger�� üũ�߱� ������ Oncollision���� 
    //���� �ʰ� Ontrigger�� �Ѵ�.
    {
        //�ε��� ������Ʈ�� �ı�
        Destroy(gameObject);
    }
}
