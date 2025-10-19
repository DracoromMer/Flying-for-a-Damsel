using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Bala : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidade = 20f;
    public Rigidbody2D rb;
    public ControlaJogadorMouseEsquerdo script;
    void Start()
    {
        rb.velocity = transform.right * velocidade;

    }

    
    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        
        Matar matar = hitInfo.GetComponent<Matar>();
        if (matar != null)
        {
            matar.Morrer();
        }
        script = GameObject.FindGameObjectWithTag("Player").GetComponent<ControlaJogadorMouseEsquerdo>();
        script.contador();
        Destroy(gameObject);
        
    }

    // Update is called once per frame

}
