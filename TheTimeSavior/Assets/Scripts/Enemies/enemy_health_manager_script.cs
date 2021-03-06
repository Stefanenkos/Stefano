﻿using UnityEngine;
using System.Collections;
using Enemies;

public class enemy_health_manager_script : MonoBehaviour
{
	public int enemyHealth;
    public bool stillAlive = true;

	public int pointsOnDeath;

	void Update ()
    {
	
		if (enemyHealth <= 0 && stillAlive)
        {
           GetComponent<EnemyDeath>().DestroyEnemy(pointsOnDeath, true);
		}
	}
    

	public void giveDamage(int damageToGive)
	{
		enemyHealth -= damageToGive;
	}
	
}
