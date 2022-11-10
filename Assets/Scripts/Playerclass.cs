using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerclass : MonoBehaviour
{
    public class plamo
    { 
        public plamo()
        {

        }
        private Vector2 direction;
        public Rigidbody2D rb;
        public bool Movement(float speed)
        {
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.y = Input.GetAxisRaw("Vertical");
            rb.MovePosition(rb.position + direction.normalized * speed * Time.fixedDeltaTime);
            if ((direction.x + direction.y) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
