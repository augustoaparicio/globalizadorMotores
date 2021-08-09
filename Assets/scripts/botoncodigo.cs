using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class botoncodigo : MonoBehaviour
{
    public void iniciarJuego()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void SalirJuego()
    {
        Application.Quit();
    }

    public void HACIAMENU()
    {
        SceneManager.LoadScene("MENU");
    }

    public void Ganar()
    {
        SceneManager.LoadScene("Ganaste");
    }

    public void Perder()
    {
        SceneManager.LoadScene("Perdiste");
    }
}
