using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMmanager : MonoBehaviour
{
    public GameObject BGM;
    private void Awake() // playOnAwake�� �������� �ʾ���
{
	
	DontDestroyOnLoad(this); // ����!
}
    
}
