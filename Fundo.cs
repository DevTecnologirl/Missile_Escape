using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundo : MonoBehaviour
{
    //Diferença de velocidade entre a movimentação do player e do deslocamento do céu
    //para efeito de profundidade
    float parallax = 2f;

    //Componente mesh do Quad onde se encontra o material do céu
    MeshRenderer mesh;

    //Referência do material da textura
    Material textura;

    //Vetor do deslocamento a ser movimentado
    Vector2 deslocamento;

    void Start()
    {
        //Referenciação dos componentes declarados
        mesh = GetComponent<MeshRenderer>();
        textura = mesh.material;
    }

    void Update()
    {
        //Pega o valor atual de deslocamento da textura do objeto
        deslocamento = textura.mainTextureOffset;

        //Altera o valor conforme sua movimentação / por sua escala e pelo parallax
        //para uma sensação de profundidade e tamanho mais realista
        deslocamento.x = transform.position.x / transform.localScale.x / parallax;
        deslocamento.y = transform.position.y / transform.localScale.y / parallax;

        //Atualiza o valor de deslocamento da textura do objeto
        textura.mainTextureOffset = deslocamento;
    }
}
