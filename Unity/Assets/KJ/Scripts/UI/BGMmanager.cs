using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMmanager : MonoBehaviour
{
    public GameObject BGM;
    private void Awake() // playOnAwake는 설정하지 않았음
{
	
	DontDestroyOnLoad(this); // 여기!
}
    
}
