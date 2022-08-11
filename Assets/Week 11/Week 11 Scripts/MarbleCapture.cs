using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MaxValentine

{
    public class MarbleCapture : MonoBehaviour
    {
        public delegate void MarbleResetAction();
        public static event MarbleResetAction OnMarbleReset;

        [SerializeField] private GameObject marbleSpawnPoint;
        // We wanted to catch any marbles that collide with this object and reset them  
        private void OnTriggerEnter(Collider marble)
        {
          // check if the "other" object is a marble
          if(marble.gameObject.CompareTag("Player"))
            {
                // reset the marble's position
                marble.gameObject.transform.position = marbleSpawnPoint.transform.position;
                marble.GetComponent<Rigidbody>().velocity = Vector3.zero;

                // If some other gameObject is LISTENING to ONMarble Reset...
                if(OnMarbleReset != null)
                {
                    // ...announce the event!
                    OnMarbleReset();
                }
            }
        }
    }
}
