using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
     // for controlling speed while running

       public float  maxRunSpeed;
    //jump

    public bool  isOnGround ;

 //  speed of player
    public float  speed;

    // classes
    private Rigidbody2D rigidbody;

   private Transform selfTransform;



   //jump

   public Vector2 jumpSpeed;

   // spawn point

   public Transform spawnPoint;

   
  
   //  for  Invisibility  of ball

 private BoxCollider2D boxCollider;

     private SpriteRenderer spriteRenderer;


     //  livemanager
   private LivesManager livesManager;


   

   


    void Start()
    {     
        // getting component of box collider
      boxCollider = GetComponent<BoxCollider2D>();
       spriteRenderer = GetComponent<SpriteRenderer>();


         //getting component of box collider
        
        rigidbody = GetComponent<Rigidbody2D>();

        // for obvious reasons

         selfTransform = transform;

          livesManager = FindObjectOfType<LivesManager>() ;

         //calling it
         SpawnPlayerOnPoint();

    


     }
  
 // now spawn player method here


     public void SpawnPlayerOnPoint(){

       
        selfTransform.position = spawnPoint.position;

    }

   public void FixedUpdate(){

        // code of physics comes here

         float moveHorizontal = Input.GetAxis("Horizontal");

          float moveVertical = Input.GetAxis("Vertical");


          // right left thing 
           if (moveHorizontal > 0 ){
                
                //face right
              selfTransform.rotation = new Quaternion(0,0,0,0);



           }else if (moveHorizontal < 0)
           {
               //facing left
                selfTransform.rotation = new Quaternion(0,-180,0,0);
               
           }
           
           // walking
          Vector2 movement = new Vector2(moveHorizontal ,moveVertical);

           

           if (rigidbody.velocity.magnitude <  maxRunSpeed)
           rigidbody.AddForce (movement*speed);     
          //  print(rigidbody.velocity.magnitude);

            
            

     
          

          // jumping

          if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
          {
            rigidbody.AddForce (jumpSpeed);
              
          }


         
          
  }

  // player die

  public void PlayerDie(){

    
   
    SpawnPlayerOnPoint();
      
  }


// this one for spawn
    void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag == TagManager.KillTriggerTag) {

             //calling it

             //now for dying
      //    SpawnPlayerOnPoint();
      //  GameManager.Instance.ResetGame();

      // so

         touching_killtrigger();
    
        }
        }


 // check ground

 // #obvios
  void OnCollisionStay2D(Collision2D collision){


          if (collision.gameObject.tag == TagManager.groundTag){
               
               isOnGround   = true;


          }

  }
     // by name they are obvious
    void OnCollisionExit2D(Collision2D collision){
 if (collision.gameObject.tag == TagManager.groundTag){
               
               isOnGround   = false;


          }

    }

    private void touching_killtrigger(){
        
        // GameManager.Instance.Gameover();

        //call your lifemanager

        livesManager.Takelife();
 
        PlayerDie();

        

    }

      // for Invisibility  of ball
  void  EnableObject(bool enabled){
         
        //  boxCollider.enabled = enabled;
         spriteRenderer.enabled = enabled;
      
     }

     public void ballinvisible(){

      EnableObject(false) ;
}


 public void ballvisible(){

      EnableObject(true) ;
}
   

 

    }



   


