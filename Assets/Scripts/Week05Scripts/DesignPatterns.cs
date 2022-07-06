using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesignPatterns : MonoBehaviour
{
    List<GameObject> players = new List<GameObject>();
    List<GameObject> enemies = new List<GameObject>();
    List<GameObject> neutralNPCs = new List<GameObject>();

    private void ResetAllEnemies()
    {
        //How do I go through a whole list of enemies?
        //What do I use?
        //... A ForLoop

        //Using a tag:
        GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
        allEnemies[0].transform.position = Vector3.zero;
        allEnemies[1].transform.position = Vector3.zero;
        allEnemies[2].transform.position = Vector3.zero;

        //16.7 miliseconds in a frame (60 FPS)
        //If FindGameObjectsWithTag("Enemy"); takes 1 milisecond
        //...we can only perform 16 of them before the framerate is affected
        //So to prevent it:
        //- Don't use GameObject.FindX during gameplay
        //- Get all your Finds done at game start
        //- When you Instantiate an object, store a reference to it (the best way?)
        //- Add all objects manually with an inspector
    }

}
