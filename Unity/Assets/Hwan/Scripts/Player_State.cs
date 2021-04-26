using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_State : MonoBehaviour
{
    enum PlayerState
    {
        Move,
        Fly,
        Respawn
    }
    
    

    public Transform flyPoint;
    public Transform startPoint;
    Transform tempPoint;

    PlayerState state;
    Material originMat;
    

    public float moveSpeed = 10f;
    public float flySpeed = 15f;
    void Start()
    {
        
        state = PlayerState.Move;
        tempPoint = flyPoint;
        originMat = startZone.GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
        switch (state)
        {
            case PlayerState.Move:
                MoveInput();
                break;
            case PlayerState.Fly:
                Fly();
                break;
            case PlayerState.Respawn:
                Respawn();
                break;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.transform.tag == "Enemy")
        {
            //state = PlayerState.Fly;
        
        }
    }

    void MoveInput()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, z);
        dir.Normalize();

        transform.position += dir * moveSpeed * Time.deltaTime;

        

        
        //cc.Move(dir * moveSpeed * Time.deltaTime);

        //startZone.GetComponent<Renderer>().material = originMat;
    }

    void Fly()
    {
        
        Vector3 dir = flyPoint.position - transform.position;
        
        transform.position += dir * flySpeed * Time.deltaTime;
        RotateCube();
        if (Vector3.Distance(flyPoint.position, transform.position) <= 2f)
        {
            flyPoint = startPoint;
            print("flyÆ÷Áö¼Ç µµÂø");
           

            if (Vector3.Distance(startPoint.position, transform.position) <= 2f)
            {
                
                flyPoint = tempPoint;

                state = PlayerState.Respawn;
                
            }
        }
        
    }

    public float rotSpeed = 2f;
    
    void RotateCube()
    {
        transform.Rotate(new Vector3(180, 180, 0) * Time.deltaTime * rotSpeed) ;
    }

    public GameObject startZone;
    public Material mat;
    
    void Respawn()
    {
        
        if (Vector3.Distance(transform.position, startPoint.position) <= 1.5f)
        {
            
            
            startZone.GetComponent<Renderer>().material = mat;
            transform.position = startPoint.position;

            StartCoroutine(bottomEft());
            
            state = PlayerState.Move;
        }
    }

    IEnumerator bottomEft()
    {
        
        startZone.GetComponent<Renderer>().material = mat;
        yield return new WaitForSeconds(0.1f);

        startZone.GetComponent<Renderer>().material = originMat;
        yield return new WaitForSeconds(0.1f);

        startZone.GetComponent<Renderer>().material = mat;
        yield return new WaitForSeconds(0.1f);

        startZone.GetComponent<Renderer>().material = originMat;
        yield return new WaitForSeconds(0.1f);
    }
}
