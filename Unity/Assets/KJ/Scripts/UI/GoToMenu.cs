
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoToMenu : MonoBehaviour
{

    public void OnClickRetry()
    {
        SceneManager.LoadScene("TitleScene");

    }
}
