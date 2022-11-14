using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunbununscript : bulletweapon
{
    public bool ch = false;
    private bool facingright = true;
    public float ofs12;
    public float ofs;
    public float a;
    public Rigidbody2D playa;
    
    private void FixedUpdate() {
        
        rotation();
        
    }
    protected void findmouse()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
            difference -= transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + ofs + ofs12);
    }
    public void rotation()
        {
            Vector3 msvect = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (((!facingright) && (transform.parent.position.x < (msvect.x) )) || ((facingright) && (transform.parent.position.x > (msvect.x) )))
            {
                facingright = !facingright;
                if(ofs12 == 180)
                {
                    ofs12 = 0;
                }
                else
                {
                    ofs12 = 180;
                }
                ch = true;
            }
            else{
                findmouse();
            }
        }
}
