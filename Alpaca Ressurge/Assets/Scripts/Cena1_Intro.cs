using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena1_Intro : MonoBehaviour
{
    // Start is called before the first frame update
      public GameObject sceneManager;
      public float delay;

      public void NextScene() 
      {
        sceneManager.GetComponent<SceneManager>().NextScene(1);

      }


    void Start()
    {
        if(delay > 0 ) 
       {
          Invoke("NextScene",delay);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}