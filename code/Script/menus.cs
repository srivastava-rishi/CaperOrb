using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class menus : MonoBehaviour
{

public string nextLevel;
      
      
      // public void Replay(){

      //    FindObjectOfType<GameManager>().ResetGame();

      // }

 public void NextLevel(){
  
      SceneManager.LoadScene(nextLevel);

      }


      public void Quitgame(){
  
       Application.Quit();

      }
        
 
}
