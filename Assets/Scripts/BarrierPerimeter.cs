﻿using UnityEngine;
using System.Collections;

public class BarrierPerimeter : MonoBehaviour
{
	[SerializeField] AllyStructureController allyStructureController;

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Enemy")
		{
			EnemyNavController enemyNavController = other.GetComponent<EnemyNavController>();
			enemyNavController.DisableMovement();
			allyStructureController.BarrierPerimeterTrigger(other.gameObject);
		}
	}
}
