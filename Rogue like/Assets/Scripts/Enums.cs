using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum Color{blue, red, yellow, green, violet, orange}

enum CarMake {Oldsmobile, Chevrolet, Dodge, Ford, Ferrari, Toyata};
enum CarModel {Alero, Cruze, Tacoma, Mustang, Camero, Viper};
public class Enums : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*Color paint;
        paint = Color.blue;

        print(paint);

        CarMake make;

        CarModel model;
        make = CarMake.Dodge;
        model = CarModel.Viper;

        print("Car Manufacturer:" + make + "Model:" + model);

        Recall(CarMake.Toyata, CarModel.Tacoma);
        */
    }


    // Update is called once per frame
    void Update()
    {
        
    }
    void Recall(CarMake make)
    {
        /*if(make == CarMake.Oldsmobile && CarModel.Alero)
        {
            print("There is a recall on your vehicle due to a high chance of explosions");
        }
        else if(make == CarMake.Ford && CarModel.Mustang)
        {
            print("There is something wrong with you. Why would you but this car? What, are you having a midlife crisis?");
        }
        else
        {
            print("There is no recall on your vehicle. There is a low chance of explosion.");
        }*/
    }
}
