using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine
{
    public class TriggerZone : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Welcome to the trigger zone! " + other.gameObject.name);

            other.transform.position = new Vector3(0, 7, 0);
            other.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
