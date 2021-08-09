using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{

    public float velocidadDeMovimiento = 5f;
    public GameObject Jugador;
    Rigidbody2D R2d;
    public float saltoFuerza = 6.5f;
    public GameObject Bala;
    public Transform SpawnBala;
    public float TasaDeDisparo;
    public int puntos = 0;
    public Text enemigosDeleteados;








    void Start()

    {
        R2d = GetComponent<Rigidbody2D>();
        puntos = 0;
    }

    void FixedUpdate()
    {
        enemigosDeleteados.text = "enemigos deleteados " + puntos;
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * velocidadDeMovimiento * Time.fixedDeltaTime);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * velocidadDeMovimiento * Time.fixedDeltaTime);
        }

        if (Input.GetKey(KeyCode.W) && checkearpiso.isGrounded)
        {
            R2d.velocity = new Vector2(R2d.velocity.x, saltoFuerza);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bala, SpawnBala.position, SpawnBala.rotation);
        }



    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "GameOver")
        {
            SceneManager.LoadScene("Perdiste");
        }


        if (puntos == 4)
        {
            if (other.tag == "win")
            {
                SceneManager.LoadScene("Ganaste");
            }
        }

    }

    public void deletearEnemigos()
    {
        puntos += 1;
       enemigosDeleteados.text = "enemigos deleteados " + puntos;

    }





}
    