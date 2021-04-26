using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text totalTimes;
    public Text totalDeaths;
    public InputField ranking;
    

    private void Start()
    {
        

        DataManager.Name = "UNKNOWN";

        totalTimes.text = "Total Times: " + DataManager.Time;

        totalDeaths.text = "Total Deaths : " + DataManager.count_Save;

    }
    void Update()

    {
        

        if (Input.GetKeyDown(KeyCode.Return))
        {
            DataManager.Name = ranking.text;
            print("확인완료" + DataManager.Name);
        }
    }

    public void submitscore()
    {
        
    }

}
