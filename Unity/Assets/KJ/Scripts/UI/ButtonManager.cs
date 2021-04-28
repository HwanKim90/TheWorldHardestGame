using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text totalTimes;
    public Text totalDeaths;
    public InputField ranking;
    DataManager rankdata;

    private void Start()
    {
        rankdata = GameObject.Find("DataManager").GetComponent<DataManager>();

        rankdata.Name = "UNKNOWN";

        totalTimes.text = "Total Times: " + rankdata.Time.ToString();

        totalDeaths.text = "Total Deaths : " + rankdata.count_Save.ToString();
    }
    void Update()

    {
        if (Input.GetKeyDown(KeyCode.Return))//얘는 엔터키
        {
            rankdata.Name = ranking.text;
            print("확인완료" + rankdata.Name);
        }
    }

    public void submitscore()//섭밋스코어에 연결된 함수
    {
        rankdata.saveInfo();
    }

}
