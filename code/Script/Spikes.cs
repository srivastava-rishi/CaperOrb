using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
 
 // initializing  our player class


 private LivesManager livesManager;


   


 void Start(){
        
        livesManager = FindObjectOfType<LivesManager>() ;

        
    }



  

void OnTriggerEnter2D(Collider2D collider){

    if(collider.gameObject.tag == TagManager.playerTag) {

        
        death();

     collider.gameObject.GetComponent<Player>().PlayerDie();



    }
   
}

private void death(){

    //its reference

//  GameManager.Instance.Gameover();

livesManager.Takelife();
 

}





}

