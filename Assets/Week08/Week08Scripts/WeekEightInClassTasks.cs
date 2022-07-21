using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MaxValentine
{
    public class WeekEightInClassTasks : MonoBehaviour
    {
        /// <summary>
        /// The different kind of fruit that exist.
        /// </summary>
        public enum Fruit
        {
            Apple,
            Avocado,
            Banana,
            Coconut,
            Orange,
            Pear,
            Pineapple
        }
        public Fruit favouriteFruit;

        public Fruit[] myFruitBasket = new Fruit[10];

        private void Start()
        {
            favouriteFruit = Fruit.Apple;
            Debug.Log("My favourite fruit is, " + favouriteFruit + "!");

            for (int i = 0; i < myFruitBasket.Length; i++)
            {
                myFruitBasket[i] = Fruit.Banana;
                Debug.Log("There is a " + myFruitBasket[i] + (" in my basket!"));

                Checkfruit(myFruitBasket[i]);
            }
            
        }
        private void Checkfruit(Fruit typeOfFruit)
        {
            //We want to output different text depnding on which fruit was chosen.
            //If it is an apple, do X.
            //If it is a banana, do Y.
            //...etc

            switch (typeOfFruit)
            {
                case Fruit.Apple:
                    Debug.Log("A doctor's worst nightmare");
                    break;
                case Fruit.Avocado:
                    Debug.Log("Green flavoured");
                    break;
                case Fruit.Banana:
                    Debug.Log("A chimp's favourite treat");
                    break;
                case Fruit.Coconut:
                    Debug.Log("I don't have a joke for this one");
                    break;
                case Fruit.Orange:
                    Debug.Log("Oranges are orange");
                    break;
                case Fruit.Pear:
                    Debug.Log("What do you call two pears? A pair");
                    break;
                case Fruit.Pineapple:
                    Debug.Log("Has a high real estate value under the sea");
                    break;
                default:
                    break;
            }
        }
    }
}