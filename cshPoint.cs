using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Collider))]

public class cshPoint : MonoBehaviour
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
				transform.Rotate(Vector3.up * 30.0f * Time.deltaTime);
				if (GameObject.Find("Cube (7)").GetComponent<cshPoint>().IsOn == true)
                {
					GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed = 0;

				}
				if (GameObject.Find("Cube (3)").GetComponent<cshPoint>().IsOn == true)
				{
					GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed = -0.01f;

				}
				if (GameObject.Find("Cube (6)").GetComponent<cshPoint>().IsOn == true)
				{
					GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed = 0.01f;

				}if (GameObject.Find("Cube (10)").GetComponent<cshPoint>().IsOn == true)
				{
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed > 0) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed += 0.0002f;
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed < 0) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed += -0.0002f;
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed < 0 && GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed > -0.001) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed = -0.001f;
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed > 0 && GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed < 0.001) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed = 0.001f;
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed == 0) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed = 0;
				}
				if (GameObject.Find("Cube (11)").GetComponent<cshPoint>().IsOn == true)
				{
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed > 0) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed -= 0.0002f;
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed < 0) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed -= -0.0002f;
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed == 0) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed = 0;
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed < 0 && GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed > -0.001) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed = -0.001f;
					if (GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed > 0 && GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed < 0.001) GameObject.Find("GameObject (4)").GetComponent<cshMove>().speed = 0.001f;

				}
				if (GameObject.Find("Cube (8)").GetComponent<cshPoint>().IsOn == true)
				{
					GameObject.Find("Player").GetComponent<cshPlayerMove>().IsOn = 1;	

				}
				if (GameObject.Find("Cube (5)").GetComponent<cshPoint>().IsOn == true)
				{
					GameObject.Find("Player").GetComponent<cshPlayerMove>().IsOn = 2;

				}
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
		LoadingBar.fillAmount = 0;


	}

}
