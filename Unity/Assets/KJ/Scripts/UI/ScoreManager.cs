using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text playerName;//플레이어 이름 UI
    public Text playTime;//플레이 시간 UI
    public Text countDeath;//죽은 횟수 UI
    int count;

    DataManager dataManager;
    UIManager uIManager;

    // Start is called before the first frame update
    void Start()
    {
        dataManager = GameObject.Find("DataManager").GetComponent<DataManager>();
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        count = dataManager.data.Count - 1;

        MyScore();
    }

    void MyScore()
    {
        uIManager.UI.SetActive(false);

        playerName.text = playerName.text + dataManager.data[count].name;
        playTime.text = playTime.text + dataManager.data[count].playTime.ToString("N2");
        countDeath.text = countDeath.text + dataManager.data[count].deathCount.ToString();

    }
}