﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena3_Quest : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sceneManager;
    public float delay;
    public GameObject alpieIdle;

      public void NextScene() 
      {
        alpieIdle.gameObject.SetActive(false);
        sceneManager.GetComponent<SceneManager>().NextScene(3);
        alpieIdle.gameObject.SetActive(true);

      }


    void Start()
    {
        if(delay > 0 ) 
       {
          Invoke("NextScene",delay);
       }
    }

    void Update()
    {
        
    }
}