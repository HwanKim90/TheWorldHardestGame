using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text textTitle;
    //알파값
    float alpha = 0;
    float dir = 1;
    public float R;
    public float G;
    public float B;
  
    void Update()
    {
        //알파값이 점점 늘어나게
        alpha += 0.01f * dir;

        //컬러값에 세팅해준다.
        textTitle.color = new Color(R, G, B, alpha);

       


        //만약에 alpha가 1보다 같거나 커지면 alpha를 0으로
        if (alpha >= 1)
        {
            dir *= -1;
        }
        if (alpha <= 0)
        {
            dir *= -1;
        }
    }
}
