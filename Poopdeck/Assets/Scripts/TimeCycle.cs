using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeCycle : MonoBehaviour
{
    public int HourLength = 60;
    public int DayLength = 1440;
    private WaitForSeconds Day;
    private WaitForSeconds Hour;
    public int currentHour = 0;

    //global integer

    //unity events

    //1440f
    void Start()
    {
        Day = new WaitForSeconds(DayLength);

        Hour = new WaitForSeconds(HourLength);

        StartCoroutine(NextDayAfterSomeTime());

        StartCoroutine(NextHourAfterSomeTime());
    }

    
    void Update()
    {
        
    }

  

    IEnumerator NextDayAfterSomeTime()
    {
        while (true)
        {
            yield return Day;
            NextDay();
        }
    }
    private void NextDay()
    {
        Debug.Log("Day 2");
    }

    IEnumerator NextHourAfterSomeTime()
    {
        while(true)
        {
            yield return Hour;
            NextHour();
        }
    }

    private void NextHour()
    {
        Debug.Log("Hour 2");
        if (currentHour <= 23)
        {
            currentHour++;
        }
        else
        {
            currentHour = 0;
            currentHour++;
        }
        Debug.Log(currentHour.ToString());      
    }

    
}
