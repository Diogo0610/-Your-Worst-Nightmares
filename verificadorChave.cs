using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class verificadorChave : MonoBehaviour
{
    public Player player;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && player.TodasChaves == true)
        {
            SceneManager.LoadScene(0);
            Debug.Log("Abriu");
        }
        else if (other.gameObject.CompareTag("Player") && player.TodasChaves == false)
        {
            Debug.Log("Não tem as chaves");
        }
    }
}
