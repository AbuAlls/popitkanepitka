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
        private bool facingright = true;
        public Rigidbody2D rb;
        public bool Movement(float speed)
        {
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.y = Input.GetAxisRaw("Vertical");
            rb.MovePosition(rb.position + direction.normalized * speed * Time.fixedDeltaTime);
            if (((!facingright) && (direction.x > 0)) || ((facingright) && (direction.x < 0)))
            {
                Flip();
            }
            if ((direction.x != 0) || (direction.y != 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void Flip()
        {
            facingright = !facingright;
            Vector3 Scaler = rb.transform.localScale;
            Scaler.x *= -1;
            rb.transform.localScale = Scaler;
        }
    }
}
