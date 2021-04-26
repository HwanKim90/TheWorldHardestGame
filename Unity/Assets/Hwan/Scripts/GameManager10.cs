using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager10 : MonoBehaviour
{
    public static GameManager10 instance;
    public Transform camMovePoint;
    public GameObject cam;

    public static int lv10_deathCnt = 0;

    public Material speedMat1;
    public Material speedMat2;
    public Material speedMat3;
     
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    

    public float MoveSpeedUp(float moveSpeed)
    {

        if (GameManager10.lv10_deathCnt > 3 && GameManager10.lv10_deathCnt < 10)
        {
            moveSpeed = 3.5f;
            ChangeColorPlayer(speedMat1);
            
            
        }

        if (GameManager10.lv10_deathCnt >= 10 && GameManager10.lv10_deathCnt < 15)
        {
            moveSpeed = 5f;
            LV10_P1EnemyMove.moveSpeed = 5f;
            
            ChangeColorPlayer(speedMat2);
            CameraChangePositionAni();
            RotCamAni();
        }

        if (GameManager10.lv10_deathCnt == 16)
        {
            ChangeColorPlayer(speedMat3);
            moveSpeed = 6.5f;
            LV10_P1EnemyMove.moveSpeed = 3f;
            

        }

        return moveSpeed;
    }
                


    void ChangeColorPlayer(Material mat)
    {
        Player_State_LV10.instance.GetComponent<Renderer>().material = mat;
    }
    void RotCamAni()
    {
       
        iTween.RotateTo(cam, iTween.Hash(
            "x", 90,
            "time", 2f
            
        ));
    }

    void CameraChangePositionAni()
    {
        
        iTween.MoveTo(cam, iTween.Hash(
            "position", camMovePoint,
            "time", 2f,
            "easetype", "easeInOutBack"
        ));
            
    }

            
            
        
}
            
      

            

       

            

