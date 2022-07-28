using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class GoodbyeRock : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Bye bye rock!");
        }
    }

}