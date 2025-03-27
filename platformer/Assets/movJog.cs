using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
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
        print((int)vel.y);

       
        if (Input.GetKeyDown(pulo) && japulou < maxpulos){
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
    void OnCollisionEnter2D(Collision2D other) {
        japulou = 0;
        
    }
}
