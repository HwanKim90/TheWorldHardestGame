using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class DeathScript : MonoBehaviour
{
    int count = 0;

    DataManager DC;
    UIManager ui;
    // Start is called before the first frame update
    void Start()
    {

        DC = GameObject.Find("DataManager").GetComponent<DataManager>();

        ui = GameObject.Find("UIManager").GetComponent<UIManager>();

        if (SceneManager.GetActiveScene().name == "Lv1_MapScene")
        {
            count = 0;
            ui.DeathUI.text = "Deaths: " + count.ToString();
        }

        if (SceneManager.GetActiveScene().name == "Lv4_MapScene")
        {
            count = DC.count_Save;//데스 저장
            ui.DeathUI.text = "Deaths: " + count.ToString();
        }

        if (SceneManager.GetActiveScene().name == "Lv10_MapScene")
        {
            count = DC.count_Save;//데스 저장
            ui.DeathUI.text = "Deaths: " + count.ToString();
        }
    }


    private void OnTriggerEnter(Collider other)
    {



        if (other.gameObject.tag == "Enemy" || other.CompareTag("RotEnemy"))
        {
            count = count + 1;
            DC.count_Save = count;
            ui.DeathUI.text = "Deaths: " + count;
        }


    }
}
