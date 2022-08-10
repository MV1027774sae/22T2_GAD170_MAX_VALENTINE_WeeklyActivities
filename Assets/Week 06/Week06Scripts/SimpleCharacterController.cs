using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaxValentine
{
    public class SimpleCharacterController : MonoBehaviour
    {
        //What does this need to do
        // - Move the character in directions of X and Z axes. (not Y; that is up... unless you can fly/jump later on)
        // When will our character move?
        // - When the player presses keys, or uses a controller. This is the "Input" of the player

        /// <summary>
        /// The speed the character moves at 
        /// </summary>

        [SerializeField] private float movementSpeed = 10;

        private void Update()
        {
            transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * movementSpeed * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime);
            // If your game is running at 60 frames per second,
            // Time.deltaTime will be equal to 0.167 seconds.

            // If your game is running at 120 frames per second,
            // Time.deltaTime will be equal to 0.083 seconds.

            // If your game is running at 4 frames per second,
            // Time.delta Time will be equal to 0.25 seconds.
        }
    }
}