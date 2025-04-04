using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
public class Dialogo : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public Button botao1;
    public Button botao2;
    public Button botao3;
    public string[] lines;
    public float textSpeed;
    private int index;


    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;
        StartDialog();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(textComponent.text == lines[index]){
                NextLine();
            }else{
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }

    }
    void StartDialog(){
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine(string custom = null,string teleporte = null){
        if (custom == null){
            foreach(char c in lines [index].ToCharArray()){
                textComponent.text += c;
                yield return new WaitForSeconds(textSpeed);
            }

        }
        else{
            textComponent.text = string.Empty;
            foreach(char c in custom.ToCharArray()){
                textComponent.text += c;
                yield return new WaitForSeconds(textSpeed);
            }
            SceneManager.LoadScene(teleporte);

        }
       
    }
    void NextLine(){
        if (index < lines.Length -1 ){
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else{
            var soma = GameManager.Pontuacaolvl1 + GameManager.Pontuacaolvl2;
            botao1.interactable = true;
            botao2.interactable = true;
            print(soma);
            if (soma >=100){
                
                botao3.interactable = true;
            }
            
        }
    }
    public void EscErrada(){
        StartCoroutine(TypeLine("TOMA NO C-","derrota"));
        
        
    }
    public void EscCorreta(){
        StartCoroutine(TypeLine("Eba! Tem como eu comprar minhas bolsas agora!","vitoria"));
        

    }
    public void trapaca(){
        GameManager.Pontuacaolvl2 = 1000;

    }



}
