using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesManager : MonoBehaviour
{
    // public int defaultlives;
    public int itscounter;


    public Text livesText;

    private GameManager gameManager;
   
   
    // Start is called before the first frame update
    
    void Start()
    {

        itscounter = PlayerPrefs.GetInt("CurrentLives");

        gameManager = FindObjectOfType<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        livesText.text = "x " + itscounter;

if(itscounter < 1){

   gameManager.Gameover();
}

    }

    public void  Takelife(){

   itscounter--;
   PlayerPrefs.SetInt("CurrentLives",itscounter);

    }

public void  Addlife(){

itscounter++;
PlayerPrefs.SetInt("CurrentLives",itscounter);
        
    }

}
