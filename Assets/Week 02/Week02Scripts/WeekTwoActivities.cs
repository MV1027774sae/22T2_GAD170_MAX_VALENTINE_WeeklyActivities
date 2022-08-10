using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace MaxValentine
{
    public class WeekTwoActivities : MonoBehaviour
    {
        // Variables go here
        private string favouriteGame = "Hollow Knight";
        private int hoursPlayed = 155;
        private float gamePrice = 17.5f;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("This is string 1. " + "This is string 2");
            Debug.Log("My favourite game is " + favouriteGame + ", I have played it for " + hoursPlayed + " hours and it cost me $" + gamePrice + ". Therefore, my value of dollars per hour is $" + gamePrice / hoursPlayed + ".");
        }

    }
}
