using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleManager : MonoBehaviour
{
    AudioSource BGM;
    UIManager UI;
    // Start is called before the first frame update
    void Start()
    {

        BGM = GameObject.Find("BGMManager").GetComponent<AudioSource>();
        UI = GameObject.Find("UIManager").GetComponent<UIManager>();
      
        BGM.Stop();
        //UI<- Title�Ŵ��� ���� �ִ¾� .UI <- UIManager�� �ִ¾� �׷��� ã�ƿ;���. �׷��� �ؾ��� �� �ڿ� Setactive�� Ȱ��ȭ ��
        UI.UI.SetActive(false);

        //�������� ����
        //BGM.GetComponent<AudioSource>().Stop(); 
        //UI.GetComponent<UIManager>().UI.SetActive(false);

    }

    public void GameStart()//��ŸƮ ��ư�� ���� �Լ�
    {
        SceneManager.LoadScene("Lv1_MapScene");
        BGM.Play();

        //�����̸Ŵ��� ������.��������Ʈ<�����̸Ŵ���>().�ۺ����� �׿��� �������� �� 

        UI.UI.SetActive(true);
        UI.gameStart = true;




    }
    // Update is called once per frame

}