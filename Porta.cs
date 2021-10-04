using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta : MonoBehaviour
{
    public Player player;
    bool abrir;
    Animator Abrir;
    public Collider PortaCollider;
    void Start()
    {
        Abrir = gameObject.GetComponent<Animator>();
        abrir = false;
        PortaCollider = GetComponent<Collider>();
    }
    void Update()
    {
        if (player.PodeAbrirPorta == true && Input.GetMouseButtonDown(0))
        {
            abrir = true;
        }
        else if (player.PodeAbrirPorta2 == true && Input.GetMouseButtonDown(0))
        {
            abrir = true;
        }
        else if (player.PodeAbrirPorta3 == true && Input.GetMouseButtonDown(0))
        {
            abrir = true;
        }
        else if (player.PodeAbrirPorta4 == true && Input.GetMouseButtonDown(0))
        {
            abrir = true;
        }
        else if (player.PodeAbrirPorta5 == true && Input.GetMouseButtonDown(0))
        {
            abrir = true;
        }
        else if (player.PodeAbrirPorta6 == true && Input.GetMouseButtonDown(0))
        {
            abrir = true;
        }
        else if (player.PodeAbrirPorta7 == true && Input.GetMouseButtonDown(0))
        {
            abrir = true;
        }
        else if (player.PodeAbrirPorta8 == true && Input.GetMouseButtonDown(0))
        {
            abrir = true;
        }
        else
        {
            abrir = false;
        }

        if (abrir == true)
        {
            Abrir.SetBool("abrir", true);
            PortaCollider.enabled = !PortaCollider.enabled;
        }
        else
        {
            Abrir.SetBool("abrir", false);
            PortaCollider.enabled = PortaCollider.enabled;
        }
    }
}
