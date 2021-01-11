using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDays : MonoBehaviour
{
    public Text daysGui;
    DateTime christmasDay; 
    DateTime firstAdvent;
    DateTime secondAdvent;
    DateTime thirdAdvent;
    DateTime fourthAdvent;
    DateTime currentDay = System.DateTime.Now;

    private int days = 0;

    void Start()
    {
        christmasDay = new DateTime(2020, 12, 24);
        firstAdvent = new DateTime(2020, 11, 29); 
        secondAdvent = new DateTime(2020, 12, 6);
        thirdAdvent = new DateTime(2020, 12, 13);
        fourthAdvent = new DateTime(2020, 12, 20);
 
        // TotalDaysToChristmas();

        daysGui.text = TotalDaysToChristmasV4().ToString();
        
    }
    private void TotalDaysToChristmas() {
        while(currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            days ++;
        }
        daysGui.text = days.ToString();
    }
    

    private void TotalDaysToChristmasV1()
    {
        while (currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            days++;
        }
        daysGui.text = days.ToString();
    }

    private void TotalDaysToChristmasV2()
    {
        int myDays = 0;
        while (currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            myDays++;
        }
        daysGui.text = myDays.ToString();
    }


    private void TotalDaysToChristmasV3()
    {
        double myDays = christmasDay.Subtract(currentDay).TotalDays;
        daysGui.text = myDays.ToString();
    
    }

    private double TotalDaysToChristmasV4()
    {
    
        return christmasDay.Subtract(currentDay).TotalDays;
    }
}
