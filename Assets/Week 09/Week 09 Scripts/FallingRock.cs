using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class FallingRock : MonoBehaviour
    {
        public int rockDamage = 5;

        private void OnCollisionEnter(Collision collision)
        {
            collision.gameObject.GetComponent<PlayerHealth>().playerHealth -= rockDamage;
            //same thing as writing "... playerHealth = playerHealth - 5;"
        }
    }
}