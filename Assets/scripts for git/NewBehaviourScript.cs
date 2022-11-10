using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public PlayerOne move;

    // Start is called before the first frame update
    void Start()
    {
        move.rb = GetComponent<Rigidbody2D>();
   

    }

    // Update is called once per frame
    void Update()
    {

        
    }

    void FixedUpdate()
    {
        move.Movement();
 
        
 
    }

}
