using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    // Velocidade de movimento da nave
    public float v_movimento;

    //Velocidade de rota��o da nave
    public float v_rotacao;

    //Refer�ncia ao componente Rigidbody
    Rigidbody2D lataria;
    void Start()
    {
        lataria = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        //Aplica uma velocidade constante para frente
        lataria.velocity = transform.up * v_movimento;

        //Aplica a rota��o ao objeto conforme o valor do Input no eixo
        transform.Rotate(0f, 0f, -SimpleInput.GetAxis("Horizontal") * v_rotacao);
    }
}
