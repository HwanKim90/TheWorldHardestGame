using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player_State_LV10 : MonoBehaviour
{
    public static Player_State_LV10 instance;
    public enum PlayerState
    {
        Move,
        Fly,
        Respawn
    }

    //public static int deathCount = 0;


    public GameObject startZone;
    public Material mat;
    public Transform flyPoint;
    public Transform startPoint;
    public static bool isFly;
    public PlayerState state;
    public float flySpeed = 15f;
    

    Material originMat;
    bool keyDown;
    float moveSpeed = 2.5f;



    private void Awake()
    {
        if (instance == null)
            instance = this;
    }
    
    void Start()
    {
        state = PlayerState.Move;
        originMat = startZone.GetComponent<Renderer>().material;
    }

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
        if (keyDown) return;

        if (other.transform.tag == "Enemy" || other.CompareTag("RotEnemy"))
        {
            state = PlayerState.Fly;
            if (GameManager10.lv10_deathCnt >= 0 && GameManager10.lv10_deathCnt <= 10) 
                GameManager10.lv10_deathCnt++;
            print(GameManager10.lv10_deathCnt);
            moveSpeed = GameManager10.instance.MoveSpeedUp(moveSpeed);
            

            //deathCount++;
            //PlayerPrefs.SetInt("deathCount", deathCount);
            //deathUI.text = "Death : " + PlayerPrefs.GetInt("deathCount");
        }
    }

    void isOverPower()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            print("오버파워!!");
            keyDown = true;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("오버파워!! 해제");
            keyDown = false;
        }

        
    }
    
    void MoveInput()
    {
        print("move상태");
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, z);
        dir.Normalize();

        transform.position += dir * moveSpeed * Time.deltaTime;
        isOverPower();
    }

    void Fly()
    {
        SoundManager.instance.PlayEFT(SoundManager.EFT_TYPE.COLLISION);
        print("fly상태");
        isFly = true;
        MoveFlyAni();
        FlyRotateAni();
        print(isFly);
        state = PlayerState.Respawn;
    }

    void MoveFlyAni()
    {
        iTween.MoveTo(gameObject, iTween.Hash(
            "position", flyPoint,

            "time", 0.7f,
            "oncomplete", "ReturnStartPointAni",
            "easetype", "easeOutCubic"
        ));
    }

    void ReturnStartPointAni()
    {
        
        iTween.MoveTo(gameObject, iTween.Hash(

             "position", startPoint,
             "time", 0.7f,
             "easetype", "easeInSine"
        ));
    }


    void FlyRotateAni()
    {
        iTween.RotateTo(gameObject, iTween.Hash(
            "rotation", new Vector3(180, 180, 180) * 5,
            "time", 2f
        ));
    }

    void Respawn()
    {
        print("Respawn상태");
        if (Vector3.Distance(transform.position, startPoint.position) <= 1f)
        {
            startZone.GetComponent<Renderer>().material = mat;
            transform.position = startPoint.transform.position;
            
            StartCoroutine(bottomEft());

            isFly = false;
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
            
            


   
        


    

    

        



    

        

                



    




























