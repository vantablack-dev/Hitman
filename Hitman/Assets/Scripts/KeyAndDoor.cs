using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class KeyAndDoor : MonoBehaviour{

	public int goldKeysCounter = 0;

	[SerializeField]
	GameObject GKSprite;

	[SerializeField]
	Transform Gate;


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("GoldKey"))
		{
			GKSprite.SetActive(true);
			goldKeysCounter++;
			other.gameObject.SetActive(false);
		}

		if (other.gameObject.CompareTag("Gate") && goldKeysCounter > 0)
		{
			GKSprite.SetActive(false);
			other.gameObject.SetActive(false);
			goldKeysCounter--;
			//Gate.position += Vector3.down * 10.0f;
		}
	}
}