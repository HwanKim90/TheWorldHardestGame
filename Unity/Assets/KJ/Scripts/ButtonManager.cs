using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text textTitle;
    //���İ�
    float alpha = 0;
    float dir = 1;
    public float R;
    public float G;
    public float B;
  
    void Update()
    {
        //���İ��� ���� �þ��
        alpha += 0.01f * dir;

        //�÷����� �������ش�.
        textTitle.color = new Color(R, G, B, alpha);

       


        //���࿡ alpha�� 1���� ���ų� Ŀ���� alpha�� 0����
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
