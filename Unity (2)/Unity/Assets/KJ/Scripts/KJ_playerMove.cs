using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KJ_playerMove : MonoBehaviour
{
    //UI
    int count = 0;

    public Text countText;


    public float speed = 5;


    void Start()
    {
        
        
    }
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");

        Vector3 dirV = Vector3.up * v;
        Vector3 dirH = Vector3.right * h;

        Vector3 dir = dirV + dirH;


        transform.position += dir * speed * Time.deltaTime;

    }
    private void OnTriggerEnter(Collider other)
    {


       
        if (other.gameObject.tag == "Enemy")
        {
            
            count = count + 1;
            countText.text = "Deaths: " + count;
        }


    }
  
    }

 

