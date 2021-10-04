using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testeAnim : MonoBehaviour
{
    bool andando;
    Animator Andar;
    void Start()
    {
        andando = false;
        Andar = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.N))
        {
            andando = true;
        }
        else
        {
            andando = false;
        }

        if (andando == false)
        {
            Andar.SetBool("Jump", false);
        }

        if (andando == true)
        {
            Andar.SetBool("Jump", true);
        }
    }
}
