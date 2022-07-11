using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextworld : MonoBehaviour
{
    

// private void OnTriggerEnter2D(Collider2D collision){

// if (collision.gameObject.tag == TagManager.playerTag) {

//  GetComponent<Collision>().gameObject.GetComponent<GameManager>().Victory();


// }

// }


void OnTriggerEnter2D(Collider2D collider){

    if(collider.gameObject.tag == TagManager.playerTag) {

        // collider.gameObject.GetComponent<GameManager>().Victory();

        GameManager.Instance.Victory();

    }


}

}

