using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�߻� Ŭ����
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

    private void Awake() // playOnAwake�� �������� �ʾ���
    {

        DontDestroyOnLoad(this); // ����!
    }

    // Start is called before the first frame update

    //������ ������ �Լ�
    public void saveInfo()//���⼭ ������ ������!
    {
        Deaths = count_Save;

        Data _data = new Data();

        _data.deathCount = Deaths;

        _data.playTime = Time;

        _data.name = Name;

        data.Add(_data);
    }

}
