using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat : MonoBehaviour
{
   public float speed;

   public bool MoveRight;

 private LivesManager livesManager;


   //  for rotation
// private Transform selfTransform;


    // Update is called once per frame

void Start(){
        
        livesManager = FindObjectOfType<LivesManager>() ;

        
    }




    void Update()
    {
        if(MoveRight) {

 //face right
        // selfTransform.rotation = new Quaternion(0,0,0,0);
       transform.Translate(2 * Time.deltaTime * speed,0,0);
       transform.localScale = new Vector2(2,2);
       
          
         }


        else{
             transform.Translate(-2 * Time.deltaTime * speed,0,0);
              transform.localScale = new Vector2(-2,2);
    
    


        }
    }


void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag == TagManager.playerTag) {

 die();

     collision.gameObject.GetComponent<Player>().PlayerDie();



        }
}
void OnTriggerEnter2D(Collider2D collider){

     if(collider.gameObject.tag == TagManager.batTurn ) {

      movp();




      }


}
private void die(){


    livesManager.Takelife();
 }

 private void movp(){

if(MoveRight){
    MoveRight = false;
        }
     else{
    MoveRight = true;
}



}


 }








