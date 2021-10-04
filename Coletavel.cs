using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public Player player;
    public GameObject Pilha, Pilha2, Pilha3, Pilha4, Pilha5, Pilha6;
    public GameObject Chave, Chave2, Chave3, Chave4, Chave5, Chave6;
    void Update()
    {
        if (player.chave == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Chave);
        }
        if (player.chave2 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Chave2);
        }
        if (player.chave3 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Chave3);
        }
        if (player.chave4 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Chave4);
        }
        if (player.chave5 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Chave5);
        }
        if (player.chave6 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Chave6);
        }

        if (player.pilha == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Pilha);
        }
        if (player.pilha2 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Pilha2);
        }
        if (player.pilha3 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Pilha3);
        }
        if (player.pilha4 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Pilha4);
        }
        if (player.pilha5 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Pilha5);
        }
        if (player.pilha6 == true && Input.GetMouseButtonDown(0))
        {
            Destroy(Pilha6);
        }
    }
}
