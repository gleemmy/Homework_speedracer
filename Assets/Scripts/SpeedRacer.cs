using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedRacer : MonoBehaviour
{
    string carModel = "GTR R35";
    string engineType = "V6 Twin Turbo";

    int carWeight = 1609;
    int yearMade = 2009;

    float maxAcceleration = 0.98f;

    bool isCarTypeSedan = false;
    bool hasFrontEngine = true;

    void Start()
    {
    print("The model is " + carModel + ". It has a " + engineType + "engine.");
    CheckWeight();
    
    if (yearMade <= 2009)
    {
        print("The car have been built in " + yearMade);
    

    int carAge = CalculateAge(yearMade);


    print ("The car age is " + carAge + "years old.");
    }
    else 
    {
        print("The car has been made in 2010's.");
        print("The maximum acceleration is " + maxAcceleration + "mph.");
    }
    }

    void CheckWeight()
    {
        if (carWeight < 1500)
    {
    print("The " + carModel + "is less than 1500 kg.");
    }
    else
    {
    print("The" + carModel + " is more than 1500 kg.");
    }
    }

    int CalculateAge (int yearMade)
    {
        return 2023 - yearMade;
    }

    string CheckCharacteristics ()
    {
        if(isCarTypeSedan)
        {
            return "The car type is sedan.";
        }
        else if (hasFrontEngine)
        {
            return "The car type is not sedan, but has a front engine.";
        }
        else
        {
            return "The car is neither sedan or has a front engine.";
        }
    }
}
    

