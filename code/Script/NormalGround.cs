using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalGround : MonoBehaviour
{
    public bool isBreakable;
     
    public BoxCollider2D boxCollider;

     public SpriteRenderer spriteRenderer;


    void Start(){
         //getting component of box collider
        boxCollider = GetComponent<BoxCollider2D>();
       spriteRenderer = GetComponent<SpriteRenderer>();

       
           // now taking them equal
        boxCollider.size = spriteRenderer.size;
     
      

    }

     

    // enable
  private void  EnableObject(bool enabled){
         
         boxCollider.enabled = enabled;
         spriteRenderer.enabled = enabled;
      
     }
         // positiobalReset(){

public void GlobalReset()  {

      EnableObject(true) ;
}


    void OnCollisionEnter2D(Collision2D collision){

   
//  ning is important :)

          if (collision.gameObject.tag == TagManager.playerTag)
          {
           if (isBreakable)
           {
            //  Destroy(gameObject); 

                
                    EnableObject(false);
               
           }
          }

    }
 
  
}
