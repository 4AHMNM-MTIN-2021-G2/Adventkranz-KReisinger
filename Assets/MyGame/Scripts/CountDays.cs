using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountDays : MonoBehaviour
{


    System.DateTime christmasDay;
    System.DateTime firstAdvent;
    System.DateTime secondAdvent;
    System.DateTime thirdAdvent;
    System.DateTime fourthAdvent;

    // Start is called before the first frame update
    void Start()
    {
        christmasDay = new System.DateTime(2020, 12, 24);
        firstAdvent = new System.DateTime(2020, 11, 29);
        secondAdvent = new System.DateTime(2020, 12, 6);
        thirdAdvent = new System.DateTime(2020, 12, 13);
        fourthAdvent = new System.DateTime(2020, 12, 20);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
