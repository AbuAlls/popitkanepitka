using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyclass : MonoBehaviour
{
    public class enemies
    {
        protected float speed;
        protected float stoppingDistance;
        protected float retreatDistance;
        public enemies(float n1, float n2, float n3)
        {
            speed = n1;
            stoppingDistance = n2;
            retreatDistance = n3;
        }
        public playamoves player;
        public Transform eenemy;
    public void enemove()
    {
        if (Vector2.Distance(eenemy.position, player.transform.position) > stoppingDistance)
        {
            eenemy.position = Vector2.MoveTowards( eenemy.position, player.transform.position, speed * Time.deltaTime);
        }
        else if ((Vector2.Distance(eenemy.position, player.transform.position) < stoppingDistance) && ((Vector2.Distance(eenemy.transform.position, player.transform.position) > retreatDistance)))
        {
            eenemy.position = this.eenemy.position;
        }
        else if(Vector2.Distance(eenemy.position, player.transform.position) > retreatDistance)
        {
            eenemy.position = Vector2.MoveTowards(eenemy.position, player.transform.position,  -speed * Time.deltaTime);
        } 
    }
    }
}
