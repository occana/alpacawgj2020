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

   public void Start()
   {
       myCanvas = myCanvas.GetComponent<Canvas>();
       myCanvas.gameObject.SetActive(true);
       cena1.gameObject.SetActive(true);
       
   }
       public void PlayGame()
   {
      myCanvas.gameObject.SetActive(false);
      cena1.gameObject.SetActive(false);

   }

   
}
   
