using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public class Data
//{
//    public int deathCount;
//    public float playTime;
//    public string name;
//}


public class DataManager : MonoBehaviour
{
    public static int Deaths;
    public static int count_Save;
    public static float Time;
    public static string Name;


    //List<Data> data = new List<Data>();
    


    private void Awake() // playOnAwake는 설정하지 않았음
    {
        DontDestroyOnLoad(this); // 여기!
    }




    //데이터 저장한 함수
    //    public void saveInfo()
    //    {
    //        Deaths = count_Save;



    //        Data _data = new Data();

    //        _data.deathCount = Deaths;

    //        _data.playTime = Time;

    //        _data.name = Name;

    //        data.Add(_data);
    //    }

}
