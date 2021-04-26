using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
	public static UIManager instance;
	public GameObject UI;
	public Text text_timer;
	public Text DeathUI;
	public bool gameStart = false;

	DataManager dataUi;
	private void Awake() // playOnAwake는 설정하지 않았음
	{
		instance = this;
		DontDestroyOnLoad(this); // 여기!
	}
	private void Start()
	{
		dataUi = GameObject.Find("DataManager").GetComponent<DataManager>();

		//StartCoroutine("Timer");
		
	}

	public void StartTimer()
    {
		gameStart = true;
		StartCoroutine("Timer");
	}
		
	IEnumerator Timer()
	{
		float time = 0;

		while (true)
		{
			if (gameStart)
			{
				time += Time.deltaTime;

				text_timer.text = "Time : " + time.ToString("N2");

				DataManager.Time = time;
			}
			else
			{
				break;
			}
			yield return null;
		}
	}
}
