using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class horiplatform : MonoBehaviour
{
   public Transform pos1, pos2;

   public float speed;

 public Transform startpos;



 





 Vector3 nextPos;
    void Start()
    {

     
    nextPos = startpos.position;

 



    }


    

    
    // Update is called once per frame
    void Update()
    {
        if(transform.position == pos1.position){
         
         nextPos = pos2.position;

        }

        if(transform.position == pos2.position){
         
         nextPos = pos1.position;

        }

        transform.position = Vector3.MoveTowards(transform.position,nextPos,speed*Time.deltaTime);
    }


    private void OnDrawGizmos(){

        Gizmos.DrawLine(pos1.position,pos2.position);
    }
}
