using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//����ü  
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

    List<Data> data = new List<Data>();



    private void Awake() // playOnAwake�� �������� �ʾ���
    {

        DontDestroyOnLoad(this); // ����!
    }



// Start is called before the first frame update



public void Test()
    {
        Data _data = new Data();

        _data.deathCount = 1;
        _data.playTime = 1.5f;
        _data.name = "Test";

        data.Add(_data);

        Debug.Log("deathCount: " + data[0].deathCount);
    }


    //������ ������ �Լ�
    public void saveInfo()
    {
        Deaths = count_Save;

        Data _data = new Data();

        _data.deathCount = Deaths;

        _data.playTime = Time;

        _data.name = Name;

        data.Add(_data);
    }

}
