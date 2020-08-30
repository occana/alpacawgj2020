using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   public Canvas myCanvas;
   public GameObject cena1;
   public GameObject cena2;
   public GameObject cena3;
   public GameObject cena4;
   public GameObject alpieIntro;
   public GameObject alpieIdle;
   public GameObject sceneManager;
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

   public void Start()
   {
       myCanvas = myCanvas.GetComponent<Canvas>();
       myCanvas.gameObject.SetActive(true);
    }
       public void PlayGame()
   {
      myCanvas.gameObject.SetActive(false);
      sceneManager.GetComponent<SceneManager>().NextScene();
   }
}