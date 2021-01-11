using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class IlluminateAdventkranz : MonoBehaviour
{
    public GameObject candleOne;
    public GameObject candleTwo;
    public GameObject candleThree;
    public GameObject candleFour;
    DateTime christmasDay; 
    DateTime firstAdvent;
    DateTime secondAdvent;
    DateTime thirdAdvent;
    DateTime fourthAdvent;
    DateTime currentDay = System.DateTime.Now;


    void Start()
    {        
        christmasDay = new DateTime(2020, 12, 24);
        firstAdvent = new DateTime(2020, 11, 29); 
        secondAdvent = new DateTime(2020, 12, 6);
        thirdAdvent = new DateTime(2020, 12, 13);
        fourthAdvent = new DateTime(2020, 12, 20);
         
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
