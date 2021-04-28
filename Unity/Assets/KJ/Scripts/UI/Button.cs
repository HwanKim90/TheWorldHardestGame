using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{

    // Update is called once per frame
   

    public void OnClickRetry()
    {
        SceneManager.LoadScene("Lv1_MapScene");

    }
}
