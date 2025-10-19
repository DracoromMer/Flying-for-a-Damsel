using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matar : MonoBehaviour
{
    public GameObject Explosão;

    public void Morrer()
    {
        Instantiate(Explosão, transform.position, transform.rotation);
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision){
    if (collision.gameObject.CompareTag("Player"))
            {
            collision.gameObject.GetComponent<ControlaJogadorMouseEsquerdo>().tomarDano(1);
            Destroy(gameObject);
        }
}
}
