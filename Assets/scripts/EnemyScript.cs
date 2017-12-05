using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Enemy generic behavior
/// </summary>
public class EnemyScript : MonoBehaviour
{
    private WeaponScript weapon;

    void Awake()
    {
        // Retrieve the weapon only once
        weapon = GetComponent<WeaponScript>();
    }

    void Update()
    {
        // Auto-fire
        if (weapon != null && weapon.CanAttack)
        {
            weapon.Attack(true);
        }
    }
}