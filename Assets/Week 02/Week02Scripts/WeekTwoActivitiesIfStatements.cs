using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaxValentine
{
    public class WeekTwoActivitiesIfStatements : MonoBehaviour
    {
        //int randomNumber = Random.Range(1f,10f)
        [SerializeField] public float randomNumber = Random.Range(1f, 10f);

        // Start is called before the first frame update
        void Start()


        {
            if ((randomNumber) == 1) Debug.Log("The number was exactly one.");
            if ((randomNumber) > 3) Debug.Log("The number was greater than three");
            if ((randomNumber) != 4) Debug.Log("The number is not 4");
            if ((randomNumber) > 5) Debug.Log("The number is greater than 5");

        }

    }
}
