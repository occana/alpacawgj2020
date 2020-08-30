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
   public GameObject sceneManager;
   public GameObject[] cenas;
   public int cenaAtual = 0;
   public float delay;
   
        

   public void Start()
   {
       myCanvas = myCanvas.GetComponent<Canvas>();
       myCanvas.gameObject.SetActive(true);
       alpieIntro.gameObject.SetActive(false);
      
    }
       public void PlayGame()
   {
      myCanvas.gameObject.SetActive(false);
      alpieIntro.gameObject.SetActive(true);
     // sceneManager.GetComponent<SceneManager>().NextScene();
      cena1.SetActive(true);
   
   }
}