using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movJog : MonoBehaviour
{
    public KeyCode dir = KeyCode.D;
    public KeyCode esq = KeyCode.A;
    public KeyCode pulo = KeyCode.Space;
    public Rigidbody2D rb2d;
    public float tampul = 10f;
    private bool japulou = false;
    public float velocidade = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        print((int)vel.y);

       
        if (Input.GetKeyDown(pulo) && !japulou){
            vel.y = tampul;
            japulou = true;
        }
        if (Input.GetKey(dir)){
            vel.x = velocidade;
        }
        if (Input.GetKey(esq)){
            vel.x = -velocidade;
        }
        rb2d.velocity = vel;
    }
    void OnCollisionEnter2D(Collision2D other) {
        japulou = false;
        
    }
}
