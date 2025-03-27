using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    // Start is called before the first frame update
    public float tempomax = 1.0f;
    public float velocidade = 1.0f;
    public float vel_multiplier = 1.0f;
    private float time = 0.0f;
    public Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        var vel = rb2d.velocity;
        vel.x = velocidade*vel_multiplier;
        rb2d.velocity = vel;
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.velocity;
        time += Time.deltaTime;
        if (time >= tempomax ){
            time = 0;
            vel.x *= -1;
            rb2d.velocity = vel;
        }
    }
}
