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
            LoseFuel(10);
        }
    }

    public void LoseFuel( int loss )
    {
        curFuel -= loss;

        FuelBar.SetFuel( curFuel );
    }
}
