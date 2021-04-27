using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//추상 클래스
public class Data
{
    public int deathCount;
    public float playTime;
    public string name;
}


public class DataManager : MonoBehaviour
{
    public int Deaths;
    public float Time;
    public string Name;
    public int count_Save;

    public List<Data> data = new List<Data>();

    private void Awake() // playOnAwake는 설정하지 않았음
    {

        DontDestroyOnLoad(this); // 여기!
    }

    // Start is called before the first frame update

    //데이터 저장한 함수
    public void saveInfo()//여기서 실제로 저장함!
    {
        Deaths = count_Save;

        Data _data = new Data();

        _data.deathCount = Deaths;

        _data.playTime = Time;

        _data.name = Name;

        data.Add(_data);
    }

}
