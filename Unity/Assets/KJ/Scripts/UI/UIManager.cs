using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public GameObject UI;//���� �״� �ϴ°�
    public Text text_timer;
    public Text DeathUI;
    public bool gameStart = false;

    DataManager dataUi;
    private void Awake() // playOnAwake�� �������� �ʾ���
    {

        DontDestroyOnLoad(this); // ����!
    }
    private void Start()
    {
        dataUi = GameObject.Find("DataManager").GetComponent<DataManager>();

        StartCoroutine("Timer");

    }

    bool IsTimerStop = false;
    IEnumerator Timer()
    {


        float time = 0;
        while (true)//�ݺ��� ��ȣ �ȿ� �ִ� ���ǹ��� ���� �� �ȿ� �ִ� ��ũ��Ʈ�� ����ȴ�. �ƴϸ� �����ٷ� �Ѿ
        {
            if (gameStart)//��ŸƮ ��ư ���� ��
            {
                IsTimerStop = true;
                time += Time.deltaTime;
                //Time.deltaTime�� ���������Ӱ� ���� ������ ������ ������ ���ϸ� ��� 0.02�������� ��ǻ���� ���ɿ� ���� ���ݾ� �ٸ�
                text_timer.text = "Time : " + time.ToString("N2");
            }
            else if (!gameStart && IsTimerStop)
            {
                IsTimerStop = false;
                print("time: " + time);
                dataUi.Time = time;
                time = 0;
            }
            yield return null;//���� ������ ������ �ϳ� �̻� �������!
        }
        //���Ⱑ �� ������
    }
}
