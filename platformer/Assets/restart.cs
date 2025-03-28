using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public string nextSceneName = "fase2";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        //Wait for 4 seconds
        yield return new WaitForSeconds(4);
        GameManager.Pontuacaolvl2 = 0;
        SceneManager.LoadScene(nextSceneName);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
