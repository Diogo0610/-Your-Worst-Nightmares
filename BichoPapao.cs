using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BichoPapao : MonoBehaviour
{
    int velocidade = 10;
    Animator Andar;
    public bool andar;
    public Transform target;
    public Znegativo zn;
    public Zpositivo zp;
    void Start()
    {
        andar = true;
        Andar = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (andar == true)
        {
            Andar.SetBool("andar", true);

            if (zn.BichoPapao == true)
            {
                transform.position += Vector3.forward * velocidade * Time.deltaTime;
            }
            if (zp.BichoPapao2 == true)
            {
                transform.position += Vector3.back * velocidade * Time.deltaTime;
            } 
        }
        if (andar == false)
        {
            transform.LookAt(target);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("DestruirInimigo"))
        {
            andar = false;
            Andar.SetBool("andar", false);
            Destroy(gameObject, 20);
        }
    }
}
