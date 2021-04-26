using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TotalScore : MonoBehaviour
{
    public Text totalTimes;
    public Text totalDeaths;
    

    private void Start()
    {


        

        totalTimes.text = "???? " + DataManager.Time;

        totalDeaths.text = "Total Deaths : " + DataManager.count_Save;

    }
    private void Update()
    {
        
    }
}