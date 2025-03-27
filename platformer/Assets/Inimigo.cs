using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D rb2d;
    private float time = 0.0f;
    public float tempomax = 1.0f;
    public float velocidade = 1.0f;
    public float vel_multiplier = 1.0f;
    private bool foidir = false;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        time += Time.deltaTime;
        if (time >= tempomax && !foidir &&vel.x == 0){
            time = 0;
            vel.x = velocidade*vel_multiplier;
            rb2d.velocity = vel;
            foidir = true;
        }
        else if (time >= tempomax && vel.x !=0){
            time = 0;
            vel.x = 0;
            rb2d.velocity = vel;
        }
        else if (time >= tempomax && foidir && vel.x == 0 ){
            time = 0;
            vel.x = velocidade*vel_multiplier*-1;
            rb2d.velocity = vel;
            foidir = false;
        }
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player")){
            print("COLIDIU COM O JOGADOR!");
            // movJog.EjetaPlayer();
        }
        
    }
}
