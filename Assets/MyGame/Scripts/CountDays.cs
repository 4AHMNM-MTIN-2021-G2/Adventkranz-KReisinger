using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDays : MonoBehaviour
{
    public Text daysGui;
    System.DateTime christmasDay; 
    System.DateTime firstAdvent;
    System.DateTime secondAdvent;
    System.DateTime thirdAdvent;
    System.DateTime fourthAdvent;
    System.DateTime currentDay = System.DateTime.Now;

    private int days = 0;

    void Start()
    {
        christmasDay = new System.DateTime(2020, 12, 24);
        firstAdvent = new System.DateTime(2020, 11, 29); 
        secondAdvent = new System.DateTime(2020, 12, 6);
        thirdAdvent = new System.DateTime(2020, 12, 13);
        fourthAdvent = new System.DateTime(2020, 12, 20);

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
