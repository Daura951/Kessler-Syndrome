using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldBar : MonoBehaviour
{
    public Slider shieldBar;
    public Shield playerShield;

    private void Start()
    {
        playerShield = GameObject.FindGameObjectWithTag("Player").GetComponent<Shield>();
        shieldBar = GetComponent<Slider>();
        shieldBar.maxValue = playerShield.maxShield;
        shieldBar.value = playerShield.maxShield;
    }

    public void SetShield(int shieldValue)
    {
        shieldBar.value = shieldValue;
    }
}