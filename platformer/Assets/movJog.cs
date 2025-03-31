using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class movJog : MonoBehaviour
{
    public KeyCode dir = KeyCode.D;
    public KeyCode esq = KeyCode.A;
    public KeyCode pulo = KeyCode.Space;
    public KeyCode correr = KeyCode.LeftShift;
    public Rigidbody2D rb2d;
    public float tampul = 10f;
    private int japulou = 0;
    private int ejetado = 0;
    public int maxpulos = 1;
    public float velocidade = 2.0f;
    public float velcorrer = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        // print((int)vel.y);

       
        if (Input.GetKeyDown(pulo) && japulou < maxpulos){
            ejetado = 0;
            vel.y = tampul;
            japulou++;
        }
        if (Input.GetKey(dir)){
            if (Input.GetKey(correr)){
                vel.x = velcorrer;
            }
            else{
                vel.x = velocidade;
            }
            
        }
        if (Input.GetKey(esq)){
            if (Input.GetKey(correr)){
                vel.x = -velcorrer;
            }
            else{
                vel.x = -velocidade;
            }
        }
        rb2d.velocity = vel;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        japulou = 0;
        if (collision.collider.CompareTag("Inimigo")){
            // print("COLIDIU COM O inimigo!");
            if(ejetado == 0)
            ejetado = 1;
            EjetaPlayer();
        }
        
    }
    public void EjetaPlayer(){
        var vel = rb2d.velocity;
        vel.x *= -5;
        vel.y *= -5;
        if(vel.x < 2 && vel.x > 0)
        {
            print("vel positiva: " + vel.x);
            vel.x = 10f * -1; 
        }
        if(vel.x > -2 && vel.x < 0)
        {
            print("vel neg: " + vel.x);
            vel.x = 10f;
        }
        if(vel.x == 0)
        {
            print("Estacionado: "+vel.x+" "+vel.y);
            vel.y = 10f;
            vel.x = -5f;
        }
        rb2d.velocity = vel;
    }
    // void OnCollisionEnter2D(Collision2D other) {
    //     japulou = 0;
    //     if (other.collider.CompareTag("Inimigo"))
    //     {
    //         var momento = rb2d.velocity;
    //         momento.x *= -10;
    //         momento.y *= -10;
    //     }
    // }

}
