using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public GameObject UI;//껏다 켰다 하는거
    public Text text_timer;
    public Text DeathUI;
    public bool gameStart = false;

    DataManager dataUi;
    private void Awake() // playOnAwake는 설정하지 않았음
    {

        DontDestroyOnLoad(this); // 여기!
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
        while (true)//반복문 괄호 안에 있는 조건문이 참일 때 안에 있는 스크립트가 실행된다. 아니면 다음줄로 넘어감
        {
            if (gameStart)//스타트 버튼 누를 때
            {
                IsTimerStop = true;
                time += Time.deltaTime;
                //Time.deltaTime은 이전프레임과 다음 프레임 사이의 간격을 말하며 평균 0.02초이지만 컴퓨터의 성능에 따라 조금씩 다름
                text_timer.text = "Time : " + time.ToString("N2");
            }
            else if (!gameStart && IsTimerStop)
            {
                IsTimerStop = false;
                print("time: " + time);
                dataUi.Time = time;
                time = 0;
            }
            yield return null;//옐드 리턴은 무조건 하나 이상 써줘야함!
        }
        //여기가 그 다음줄
    }
}
