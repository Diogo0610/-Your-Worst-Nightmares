using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zpositivo : MonoBehaviour
{
    public GameObject BichoPapao2;
    float Tempo = 21f;
    bool Papao2 = false;
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
                Papao2 = true;
                Instantiate(BichoPapao2, new Vector3(-12.11f, -5.7254f, 412.34f), Quaternion.identity);
            }
            else
            {
                Papao2 = false;
            }
        }
    }
}
