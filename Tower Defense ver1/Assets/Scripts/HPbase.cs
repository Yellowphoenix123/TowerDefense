using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbase : MonoBehaviour
{
	public int HP = 10;
	public Text HPtext;

	// Use this for initialization
	void Update()
	{
		HPtext.text = HP.ToString();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy"))
		{
			HP -= 1;
			Destroy(other.gameObject);
			Destroy(other.GetComponent<MoveTowayPoints>().hp);
		}
	}

}
