using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    //Variaveis para movimentacao
    float speed = 10f;
    public Camera CameraFPS;

    //Variaveis para o personagem
    int vida = 5;
    string situacao;
    public bool TodasChaves, Ligado, andando;
    public bool pilha, pilha2, pilha3, pilha4, pilha5, pilha6 = false;
    public bool chave, chave2, chave3, chave4, chave5, chave6 = false;
    public bool PodeAbrirPorta, PodeAbrirPorta2, PodeAbrirPorta3, PodeAbrirPorta4, PodeAbrirPorta5, PodeAbrirPorta6, PodeAbrirPorta7, PodeAbrirPorta8 = false;
    public int chaves;
    int Energia = 1000;
    public int baterias;
    Animator Andando;


    //HUD
    public Text textosituacao;
    public Text textochaves;
    public Text textobaterias;

    void Start()
    {
        TodasChaves = false;
        chaves = 0;
        textochaves.text = "0";
        textobaterias.text = "2";
        Ligado = false;
        baterias = 2;
        PodeAbrirPorta = false;
        Andando = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        Movimentacao();
        TrocaSituacao();
        Chaves();
        Baterias();
        Interacao();
        Animacao();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Inimigo"))
        {
            vida--;
        }

        if (other.gameObject.CompareTag("Chave") && chaves <= 5)
        {
            chave = true;
            Debug.Log("1");
        }
        if (other.gameObject.CompareTag("Chave2") && chaves <= 5)
        {
            chave2 = true;
            Debug.Log("2");
        }
        if (other.gameObject.CompareTag("Chave3") && chaves <= 5)
        {
            chave3 = true;
            Debug.Log("3");
        }
        if (other.gameObject.CompareTag("Chave4") && chaves <= 5)
        {
            chave4 = true;
            Debug.Log("4");
        }
        if (other.gameObject.CompareTag("Chave5") && chaves <= 5)
        {
            chave5 = true;
            Debug.Log("5");
        }
        if (other.gameObject.CompareTag("Chave6") && chaves <= 5)
        {
            chave6 = true;
            Debug.Log("6");
        }

        if (other.gameObject.CompareTag("Pilha") && baterias <= 6)
        {
            pilha = true;
            Debug.Log("1.1");
        }
        if (other.gameObject.CompareTag("Pilha2") && baterias <= 6)
        {
            pilha2 = true;
            Debug.Log("2.2");
        }
        if (other.gameObject.CompareTag("Pilha3") && baterias <= 6)
        {
            pilha3 = true;
            Debug.Log("3.3");
        }
        if (other.gameObject.CompareTag("Pilha4") && baterias <= 6)
        {
            pilha4 = true;
            Debug.Log("4.4");
        }
        if (other.gameObject.CompareTag("Pilha5") && baterias <= 6)
        {
            pilha5 = true;
            Debug.Log("5.5");
        }
        if (other.gameObject.CompareTag("Pilha6") && baterias <= 6)
        {
            pilha6 = true;
            Debug.Log("6.6");
        }

        if (other.gameObject.CompareTag("Porta"))
        {
            PodeAbrirPorta = true;
        }
        if (other.gameObject.CompareTag("Porta2"))
        {
            PodeAbrirPorta2 = true;
        }
        if (other.gameObject.CompareTag("Porta3"))
        {
            PodeAbrirPorta3 = true;
        }
        if (other.gameObject.CompareTag("Porta4"))
        {
            PodeAbrirPorta4 = true;
        }
        if (other.gameObject.CompareTag("Porta5"))
        {
            PodeAbrirPorta5 = true;
        }
        if (other.gameObject.CompareTag("Porta6"))
        {
            PodeAbrirPorta6 = true;
        }
        if (other.gameObject.CompareTag("Porta7"))
        {
            PodeAbrirPorta7 = true;
        }
        if (other.gameObject.CompareTag("Porta8"))
        {
            PodeAbrirPorta8 = true;
        }
    }
    
    void Movimentacao()
    {
        float horizontal = Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        float vertical = Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        transform.Translate(horizontal, 0, vertical);

        if (Energia == 0 && baterias > 0)
        {
            if (Input.GetMouseButtonDown(2))
            {
                baterias--;
                Energia = +1000;
            }
        }
    }
    void TrocaSituacao()
    {
        if (vida >= 4)
        {
            situacao = "Bem";
            textosituacao.text = "Corajoso";
        }
        else if (vida == 3 || vida == 2)
        {
            situacao = "Ferido";
            textosituacao.text = "Assustado";
        }
        else if (vida == 1)
        {
            situacao = "Crítico";
            textosituacao.text = "Aterrorizado";
        }
        else if (vida == 0)
        {
            SceneManager.LoadScene(0);
        }
    }
    void Chaves()
    {
        if (chaves == 6)
        {
            TodasChaves = true;
            textochaves.text = "Todas as chaves coletadas.";
        }
        else if (chaves == 0)
        {
            textochaves.text = "0";
        }
        else if (chaves == 1)
        {
            textochaves.text = "1";
        }
        else if (chaves == 2)
        {
            textochaves.text = "2";
        }
        else if (chaves == 3)
        {
            textochaves.text = "3";
        }
        else if (chaves == 4)
        {
            textochaves.text = "4";
        }
        else if (chaves == 5)
        {
            textochaves.text = "5";
        }
    }
    void Baterias()
    {
        if (baterias == 0)
        {
            textobaterias.text = "0";
        }
        else if (baterias == 1)
        {
            textobaterias.text = "1";
        }
        else if (baterias == 2)
        {
            textobaterias.text = "2";
        }
        else if (baterias == 3)
        {
            textobaterias.text = "3";
        }
        else if (baterias == 4)
        {
            textobaterias.text = "4";
        }
        else if (baterias == 5)
        {
            textobaterias.text = "5";
        }
    }
    void Interacao()
    {
        if (chave == true && Input.GetMouseButtonDown(0))
        {
            chaves++;
            chave = false;
        }
        if (chave2 == true && Input.GetMouseButtonDown(0))
        {
            chaves++;
            chave2 = false;
        }
        if (chave3 == true && Input.GetMouseButtonDown(0))
        {
            chaves++;
            chave3 = false;
        }
        if (chave4 == true && Input.GetMouseButtonDown(0))
        {
            chaves++;
            chave4 = false;
        }
        if (chave5 == true && Input.GetMouseButtonDown(0))
        {
            chaves++;
            chave5 = false;
        }
        if (chave6 == true && Input.GetMouseButtonDown(0))
        {
            chaves++;
            chave6 = false;
        }

        if (pilha == true && Input.GetMouseButtonDown(0))
        {
            baterias++;
            pilha = false;
        }
        if (pilha2 == true && Input.GetMouseButtonDown(0))
        {
            baterias++;
            pilha2 = false;
        }
        if (pilha3 == true && Input.GetMouseButtonDown(0))
        {
            baterias++;
            pilha3 = false;
        }
        if (pilha4 == true && Input.GetMouseButtonDown(0))
        {
            baterias++;
            pilha4 = false;
        }
        if (pilha5 == true && Input.GetMouseButtonDown(0))
        {
            baterias++;
            pilha5 = false;
        }
        if (pilha6 == true && Input.GetMouseButtonDown(0))
        {
            baterias++;
            pilha6 = false;
        }
    }
    void Animacao()
    {
        if (Input.GetKey("up") || Input.GetKey(KeyCode.W))
        {
            andando = true;
            Andando.SetBool("andando", true);
        }
        else
        {
            andando = false;
            Andando.SetBool("andando", false);
        }
    }
}