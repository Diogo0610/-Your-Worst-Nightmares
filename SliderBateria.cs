using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderBateria : MonoBehaviour
{
    Slider Bateria;
    int Energia = 1000;
    bool Ligado;
    public Player player;
    void Awake()
    {
        Bateria = GetComponent<Slider>();
        Ligado = false;
    }
    void Update()
    {
        Bateria.value = Energia;

        if (Ligado == false)
        {
            if (Input.GetMouseButtonDown(1) && Energia > 1)
            {
                Ligado = true;
                //luz.SetActive(true);
            }
        }
        else if (Ligado == true)
        {
            Energia--;
            if (Input.GetMouseButtonDown(1) || Energia == 0)
            {
                Ligado = false;
            }
        }
        if (Energia == 0 && player.baterias > 0)
        {
            if (Input.GetMouseButtonDown(2))
            {
                player.baterias--;
                Energia = +1000;
            }
        }
    }
}
