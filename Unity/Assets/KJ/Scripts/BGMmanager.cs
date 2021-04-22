using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMmanager : MonoBehaviour
{
    public GameObject BGM;
    private void Awake() // playOnAwake는 설정하지 않았음
{
	
	DontDestroyOnLoad(BGM); // 여기!
}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
