using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


    // to get ride of centre character
     
     public float offset;


    //to get the position of player we acess  this class
   public Transform playerTransform;

// for obvious reasons 
  Transform  selfTransform ;


    void Start()
    {

        playerTransform = GameObject.FindGameObjectWithTag(TagManager.playerTag).transform;

        // wtf

          selfTransform = transform;
        
    }

    // we always put the camera update in late update

    void LateUpdate(){

        //playerTransform.position.x =  exact position of player

        // selfTransform.position.y =  default no  that is 0; 
       
    
        Vector3 movePosition =  new Vector3(playerTransform.position.x - offset ,selfTransform.position.y,selfTransform.position.z);



       //for smoothness

        selfTransform.position = Vector3.Lerp(selfTransform.position,movePosition,Time.deltaTime * 5);


    }
}
