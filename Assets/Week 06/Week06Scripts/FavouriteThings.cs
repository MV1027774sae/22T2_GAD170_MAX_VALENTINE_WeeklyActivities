using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaxValentine
{
    public class FavouriteThings : MonoBehaviour
    {
        string[] favouriteThings = { "Apple", "Orange", "Banana" };
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(favouriteThings);
        }
    }
}
