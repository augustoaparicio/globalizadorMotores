using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public player R1ley;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bala")
        {
            
            Destroy(this.gameObject);
            R1ley.deletearEnemigos();


        }
    }
}
