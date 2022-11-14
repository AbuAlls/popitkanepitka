using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class playamoves : Playerclass
{
    private plamo playa = new plamo();
    private Animator anim;
    public float speed;
    void Start()
    {
        playa.rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        anim.SetBool("isrun", playa.Movement(speed));
        playa.rotation();
    }
}
