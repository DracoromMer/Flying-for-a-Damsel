using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ControlaJogadorMouseEsquerdo : MonoBehaviour {

  bool comecou;
  bool acabou;
  Rigidbody2D corpoJogador;
  Vector2 forcaImpulso = new Vector2(0, 500f);

  private int count;

  public GameObject Vitoria;

  public GameObject Derrota;

  public GameObject GeraInimigo;

  public TextMeshProUGUI contaInimigo;

  public float vidaAtual;
  public float vidaMaxima = 5;

  public BarraDeVida barradevida;

  public float LimiteY;


void SetCountText()
    {
        contaInimigo.text = "Enemies Left: " + count.ToString();
    if (count <= 0)
    {
      Vitoria.SetActive(true);
      Destroy(GeraInimigo);
      DesativarJogador();
        }
        

    }
  void Start()
  {
    corpoJogador = GetComponent<Rigidbody2D>();
    count = 12;
    vidaAtual = vidaMaxima;
    SetCountText();
    barradevida.MarcarVidaMaxima(vidaMaxima);

  }
  public void contador()
    {
    count = count - 1;
    SetCountText();
    }

  void Update()
  {

    if (Input.GetButtonDown("Fire1"))
    {

      if (!comecou)
      {
        comecou = true;
        corpoJogador.isKinematic = false;
      }

      corpoJogador.velocity = new Vector2(0, 0);
      corpoJogador.AddForce(forcaImpulso);
    }

  }
  private void DesativarJogador()
  {
    corpoJogador.bodyType = RigidbodyType2D.Static;
  }

  public void tomarDano(float dano)
  {
    vidaAtual -= dano;
    barradevida.MarcarVida(vidaAtual);
    if (vidaAtual <= 0)
    {
      vidaAtual = 0;
      Debug.Log("Felpudo Morreu");
      Derrota.SetActive(true);
      Destroy(GeraInimigo);
      DesativarJogador();
    }
  }
}
