using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPlace : MonoBehaviour
{
	public GameObject Tower1;
	public GameObject Tower2;
	public Vector3 offset;
	public GameObject curTower;
	int empty = 0;
	public GameObject Controller;





	void Update()
	{
		Controller = GameObject.Find("Main Camera");



	}
	void OnMouseDown()
	{
		if (empty == 0 && Controller.GetComponent<GameController>().Gold >= 50)
		{
			curTower = GameObject.Instantiate(Tower1, transform.position + offset, Quaternion.identity) as GameObject;
			empty = 1;
			Controller.GetComponent<GameController>().Gold -= 50;

		}
		else if (empty == 1 && Controller.GetComponent<GameController>().Gold >= 50)
		{
			curTower.SetActive(false);
			curTower = GameObject.Instantiate(Tower2, transform.position + offset, Quaternion.identity) as GameObject;
			empty = 2;
			Controller.GetComponent<GameController>().Gold -= 50;
			
		}

	}




}
