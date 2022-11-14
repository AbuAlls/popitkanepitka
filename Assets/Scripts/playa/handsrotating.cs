using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handsrotating : MonoBehaviour
{
    public float ofs;
    public bool ch = false;
    private bool facingright = true;
    public float ofs12;
    public Vector3 difference;
    public float A;
    private void FixedUpdate() {
        
        rotation();
    }
    protected void findmouse()
    {
        difference = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if ((difference.x + difference.y) > (transform.position.y + transform.position.x + 2))//rotation -28!
        {
            difference -= transform.position;
            float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0f, 0f, rotZ + ofs + ofs12);
        } 
    }
    public void rotation()
        {
            Vector3 msvect = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (((!facingright) && (transform.parent.position.x < msvect.x )) || ((facingright) && (transform.parent.position.x > msvect.x )))
            {
                facingright = !facingright;
                if(ofs12 == 200)
                {
                    ofs12 = 0;
                }
                else
                {
                    ofs12 = 200;
                }
            }
            else{
                findmouse();
            }
        }
}
