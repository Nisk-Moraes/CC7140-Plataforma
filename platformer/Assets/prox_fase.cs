using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class prox_fase : MonoBehaviour
{

    public string nextSceneName = "fase2";
    

    // Esta função será chamada automaticamente quando o jogador colidir com o objeto
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifique se o objeto que entrou em contato tem o tag "Player"
        if (other.CompareTag("Player"))
        {
            // Carrega a próxima cena
            SceneManager.LoadScene(nextSceneName);

        }
    }

}
