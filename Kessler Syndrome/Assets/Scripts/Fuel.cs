using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public int curFuel = 0;
    public int maxFuel = 100;

    public FuelBar fuelBar;

    void Start()
    {
        curFuel = maxFuel;
    }

    void Update()
    {
        if( Input.GetKeyDown( KeyCode.Space ) )
        {
            DecreaseFuel(10);
        }
    }

    public void DecreaseFuel( int fuel )
    {
        curFuel -= fuel;

        fuelBar.SetFuel( curFuel );
    }
}
