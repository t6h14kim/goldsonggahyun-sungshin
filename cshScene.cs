using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Collider))]

public class cshScene : MonoBehaviour
{
	public Image LoadingBar;
	private bool IsOn;
	private float barTime = 0.0f;
	void Start()
	{
		IsOn = false;
		LoadingBar.fillAmount = 0;
	}
	// Start is called before the first frame update
	void Update()
	{
		if (IsOn)
		{
			if (barTime <= 1.0f)
			{
				barTime += Time.deltaTime;
			}
			LoadingBar.fillAmount = barTime / 1.0f;
			if (barTime > 1.0f)
			{
			//	transform.Rotate(Vector3.up * 30.0f * Time.deltaTime);
				SceneManager.LoadScene("gsgh ctrl");
			}
		}

		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Application.Quit();
		}
	}
	public void SetGazedAt(bool gazedAt)
	{
		IsOn = gazedAt;
		barTime = 0.0f;
		if (gazedAt)
			Debug.Log("In");
		else
			Debug.Log("Out");
		//LoadingBar.fillAmount = 0;


	}

}
