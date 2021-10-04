using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    int Energia = 1000;
    bool Ligado;
    public GameObject luz;
    public Player player;
    void Start()
    {
        Ligado = false;
    }
    void Update()
    {
        if (Ligado == false)
        {
            luz.SetActive(false);
            if (Input.GetMouseButtonDown(1) && Energia > 1)
            {
                Ligado = true;
            }
        }
        else if (Ligado == true)
        {
            luz.SetActive(true);
            Energia--;
            if (Input.GetMouseButtonDown(1) || Energia == 0)
            {
                Ligado = false;
            }
        }        
        if (Energia ==0 && player.baterias > 0)
        {
            if (Input.GetMouseButtonDown(2))
            {
                Energia = +1000;
            }
        }
    }
}
