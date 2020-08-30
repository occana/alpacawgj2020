using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{  
    public GameObject[] cenas;
    public int cenaAtual = 0;

    public void NextScene () 
    {
        cenaAtual++;
        for (int i = 0; i < cenas.Length; i++)
        {
            cenas[i].SetActive(i == cenaAtual);

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
