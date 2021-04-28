using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TitleManager : MonoBehaviour
{
    AudioSource BGM;
    UIManager UI;
    // Start is called before the first frame update
    void Start()
    {

        BGM = GameObject.Find("BGMManager").GetComponent<AudioSource>();
        UI = GameObject.Find("UIManager").GetComponent<UIManager>();
      
        BGM.Stop();
        //UI<- Title매니저 씬에 있는애 .UI <- UIManager에 있는애 그래서 찾아와야함. 그렇게 해야지 그 뒤에 Setactive가 활성화 됨
        UI.UI.SetActive(false);

        //같은거임 ㅋㅋ
        //BGM.GetComponent<AudioSource>().Stop(); 
        //UI.GetComponent<UIManager>().UI.SetActive(false);

    }

    public void GameStart()//스타트 버튼에 들어가는 함수
    {
        SceneManager.LoadScene("Lv1_MapScene");
        BGM.Play();

        //유아이매니저 변수명.겟컴포넌트<유아이매니저>().퍼블릭으로 겜옵젝 만들어놨던 거 

        UI.UI.SetActive(true);
        UI.gameStart = true;




    }
    // Update is called once per frame

}