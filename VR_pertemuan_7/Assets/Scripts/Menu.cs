using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
   
   public void pindahHalaman(string halaman)
   {
    
       SceneManager.LoadScene(halaman);
   }

   public void keluarAplikasi()
   {
       Application.Quit();
   }
}
