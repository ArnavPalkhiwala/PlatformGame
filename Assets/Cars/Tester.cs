using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{

    // public int myNumber = 34;
    // public string myString = "hi";
    // public bool myBool = true;
    // public float myFloat = 45.788f;
    // public double myDouble = 78.90;
    // public char myChar = 'a';
    // public int wheels = 4;
    // public int speed = 5;
    public int coins = 10;

    // Start is called before the first frame update
    void Start()
    {
        // if (wheels < 4)
        // {
        //     Debug.Log("You can't start the car");
        // }

        // else if (wheels == 4)
        // {
        //     Debug.Log("You can start the car");
        // }

        // else if(wheels >= 5 && wheels >= 18)
        // {
        //     Debug.Log("You are a truck");

        // }

        // else if (wheels == 20 || wheels == 30)
        // {
        //    Debug.Log("You have tons of wheels");

        // }

        // else
        // {
        //     Debug.Log("Something went wrong");

        // }
        // int coinsGenerated = 0;
        // while (coinsGenerated > coins)
        // {
        //     Debug.Log(coinsGenerated + " coins generated" );
        //     coinsGenerated++;
        // }

        for (int i = 0; i < coins; i++)
        {
            Debug.Log(i + " coins generated");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
