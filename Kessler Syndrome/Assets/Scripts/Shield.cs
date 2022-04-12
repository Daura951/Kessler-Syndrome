using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public int curShield = 0;
    public int maxShield = 100;

    public ShieldBar shieldBar;

    void Start()
    {
        curShield = maxShield;
    }

    void Update()
    {
        if( Input.GetKeyDown( KeyCode.Space ) )
        {
            LoseShield(10);
        }
    }

    public void LoseShield( int damage )
    {
        curShield -= damage;

        shieldBar.SetShield( curShield );
    }
}