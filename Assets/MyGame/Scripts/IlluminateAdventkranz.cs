using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IlluminateAdventkranz : MonoBehaviour
{
    public GameObject candleOne;
    public GameObject candleTwo;
    public GameObject candleThree;
    public GameObject candleFour;
    System.DateTime christmasDay; 
    System.DateTime firstAdvent;
    System.DateTime secondAdvent;
    System.DateTime thirdAdvent;
    System.DateTime fourthAdvent;
    System.DateTime currentDay = System.DateTime.Now;


    void Start()
    {        
        christmasDay = new System.DateTime(2020, 12, 24);
        firstAdvent = new System.DateTime(2020, 11, 29); 
        secondAdvent = new System.DateTime(2020, 12, 6);
        thirdAdvent = new System.DateTime(2020, 12, 13);
        fourthAdvent = new System.DateTime(2020, 12, 20);
         
        candleOne.SetActive(false);
        candleTwo.SetActive(false);
        candleThree.SetActive(false);
        candleFour.SetActive(false);

        if(currentDay.CompareTo( firstAdvent) >= 0) {
               Debug.Log("K1 Brennt");
               candleOne.SetActive(true);
         
        }
        if(currentDay.CompareTo( secondAdvent) >= 0) {
               Debug.Log("K2 Brennt");
                candleTwo.SetActive(true);
        }
        if(currentDay.CompareTo( thirdAdvent) >= 0) {
               Debug.Log("K3 Brennt");
                candleThree.SetActive(true);
        }
        if(currentDay.CompareTo( fourthAdvent) >= 0) {
               Debug.Log("K4 Brennt");
                candleFour.SetActive(true);
        }
    }
}
