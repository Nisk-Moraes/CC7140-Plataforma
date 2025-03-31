using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Moeda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other) {
        // Verifique se o objeto que entrou em contato tem o tag "Player"
        if (other.CompareTag("Player"))
        {
            if (SceneManager.GetActiveScene().name == "fase1"){
                GameManager.Pontuacaolvl1 += 10;
            }
            else{
                GameManager.Pontuacaolvl2 += 10;
            }
            
            Destroy(gameObject);
        }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
