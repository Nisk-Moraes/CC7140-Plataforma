using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Pontuacaolvl1 = 0;
    public static int Pontuacaolvl2 = 0;
    
    
    
    public GUISkin layout;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        var soma = Pontuacaolvl1 + Pontuacaolvl2;
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width / 2 - 200 - 12, 40, 100, 100), "Score: " + soma);
    }
}
