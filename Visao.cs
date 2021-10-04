using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visao : MonoBehaviour
{
    public Transform Player;
    public float Sensitividade;
    float RotacaoX;
    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
    }
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Sensitividade * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * Sensitividade * Time.deltaTime;

        RotacaoX -= mouseY;
        RotacaoX = Mathf.Clamp(RotacaoX, -60, 75);

        transform.localRotation = Quaternion.Euler(RotacaoX, 0, 0);
        Player.Rotate(Vector3.up * mouseX);
    }
}
