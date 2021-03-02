using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class StartScreen : MonoBehaviour
{
	[SerializeField]
	GameObject StartScr;

	void Update()
	{
		if (Input.touchCount > 0)
		{
			StartScr.SetActive(false);
		}
	}
}
