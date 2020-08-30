using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cena2_BatePapo : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sceneManager;
    public GameObject alpieIdle;
    public float delay;
    
   

      public void NextScene() 
      {
        alpieIdle.gameObject.SetActive(false);
        sceneManager.GetComponent<SceneManager>().NextScene(2);
        alpieIdle.gameObject.SetActive(true);

      }

        void Start()
       {
            if(delay > 0 ) 
             {
               Invoke("NextScene",delay);
             }
      }

}

