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
 
        TotalDaysToChristmas();
        
    }
    private void TotalDaysToChristmas() {
        while(currentDay.CompareTo(christmasDay) < 0)
        {
            currentDay = currentDay.AddDays(1);
            days ++;
        }
        daysGui.text = days.ToString();
    }
}
