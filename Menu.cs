using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Iniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void Ajustes()
    {
        SceneManager.LoadScene(2);
    }
    public void Creditos()
    {
        SceneManager.LoadScene(3);
    }
    public void Voltar()
    {
        SceneManager.LoadScene(0);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(4);
    }
    public void Sair()
    {
        Application.Quit();
        Debug.Log("Botão Pressionado");
    }
}
