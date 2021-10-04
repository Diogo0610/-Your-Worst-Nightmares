using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Znegativo : MonoBehaviour
{
    public GameObject BichoPapao;
    float Tempo = 21f;
    bool Papao;
    void Update()
    {
        Tempo--;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            Tempo--;
            if (Tempo == 0)
            {
                Papao = true;
                Instantiate(BichoPapao, new Vector3(-0.08f, -5.725426f, -3.9f), Quaternion.identity);
            }
            else
            {
                Papao = false;
            }
        }
    }
}
