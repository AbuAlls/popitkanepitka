using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhandbit : enemyclass
{
    
    public float speed;
    public float stoppingDistance;
    public float retreatDistance;
    public enemies enemy;
    void Start()
    {
        enemy = new enemies(speed, stoppingDistance, retreatDistance);
        enemy.player = FindObjectOfType<playamoves>();
        enemy.eenemy = GetComponent<Transform>();
    }


    void FixedUpdate()
    {
        enemy.enemove();
    }
}
