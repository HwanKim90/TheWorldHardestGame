using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMmanager : MonoBehaviour
{
    public GameObject BGM;
    private void Awake() // playOnAwake�� �������� �ʾ���
{
	
	DontDestroyOnLoad(BGM); // ����!
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
