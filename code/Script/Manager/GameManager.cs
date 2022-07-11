using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 


public class GameManager : MonoBehaviour
{
   
// making our singleton here:
private static GameManager _instance;

public GameObject winnnerScreen;

public GameObject loserScreen;

 public Player acessit;


 public string mainmenu;






public static GameManager Instance 

{


    get

    {

        if(_instance == null){

            _instance = GameObject.FindObjectOfType<GameManager>();


        }

        return _instance;
    }
    }
    //  reference of all our ground  
    //  here  i used  NormalGround because it contains script of all other
    
   public  NormalGround[] allGrounds;


    void Start(){

        // this could be it : ) 
     acessit = GameObject.FindGameObjectWithTag(TagManager.playerTag).GetComponent<Player>();


    allGrounds = FindObjectsOfType<NormalGround>();
 winnnerScreen.SetActive(false);
  loserScreen.SetActive(false);
 

   
    }


    public  void Victory()
    {
winnnerScreen.SetActive(true);
acessit.ballinvisible();
// this is it

        
       


    }

    public void Gameover(){
      
      loserScreen.SetActive(true);
      acessit.ballinvisible();

      
     //  now acessing it

StartCoroutine("Timethinge");


    }


    // for dealying things: 
    IEnumerator Timethinge()   {

yield return new WaitForSeconds(3F);
SceneManager.LoadScene(mainmenu);


    }
public void ResetGame(){

      winnnerScreen.SetActive(false);
       loserScreen.SetActive(false);
       acessit.ballvisible();

      

    for(int  i = 0; i < allGrounds.Length; i++)
    {
        allGrounds[i].GlobalReset();
    }

     


}










}
