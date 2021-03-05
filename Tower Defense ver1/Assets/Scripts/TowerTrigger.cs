using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTrigger : MonoBehaviour
{
	public Tower twr;
	public bool lockE;
	public GameObject curTarget;
	bool ene = false;
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Enemy") && !lockE)
		{
			twr.target = other.gameObject.transform;
			curTarget = other.gameObject;
			lockE = true;
		}
	}
	void Update()
	{
		


		if (curTarget == null)
		{
			lockE = false;
			//OnTriggerEnter;
		}

	}
	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Enemy") && other.gameObject == curTarget)
		{
			lockE = false;
		}
	}
}
