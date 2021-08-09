using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balas : MonoBehaviour

{
    private Rigidbody2D rbBala;
    public float velocidadBala;
    public player R1ley;
    private void Awake()
    {
        rbBala = GetComponent<Rigidbody2D>();

    }

    void Start()

    {
        rbBala.velocity = transform.up * velocidadBala;
        
    }

   
    
    

}
