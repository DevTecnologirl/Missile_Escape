using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    //Referencia do objeto Nave
    public GameObject nave;

    //Limite da movimentacao
    Vector3 movimentacao;

    void Start()
    {
      //Diferenca entre a sua posicao inicial e a do player
      movimentacao = transform.position - nave.transform.position;
    }

    void Update()
    {
        //Posicao da camera conforme a do player + a movimentao para manter distancia
        transform.position = nave.transform.position + movimentacao;
        
    }
}
